// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System;
using Microsoft.DotNet.Cli.Utils;

namespace Microsoft.DotNet.Cli.Utils
{
    /// <summary>
    /// A class which encapsulates logic needed to forward arguments from the current process to another process
    /// invoked with the dotnet.exe host.
    /// </summary>
    internal class ForwardingAppImplementation
    {
        private const string HostExe = "dotnet";

        private readonly string _forwardApplicationPath;
        private readonly IEnumerable<string> _argsToForward;
        private readonly string _depsFile;
        private readonly string _runtimeConfig;
        private readonly string _additionalProbingPath;
        private Dictionary<string, string> _environmentVariables;

        private readonly string[] _allArgs;

        public ForwardingAppImplementation(
            string forwardApplicationPath,
            IEnumerable<string> argsToForward,
            string depsFile = null,
            string runtimeConfig = null,
            string additionalProbingPath = null,
            Dictionary<string, string> environmentVariables = null)
        {
            _forwardApplicationPath = forwardApplicationPath;
            _argsToForward = argsToForward;
            _depsFile = depsFile;
            _runtimeConfig = runtimeConfig;
            _additionalProbingPath = additionalProbingPath;
            _environmentVariables = environmentVariables;

            var allArgs = new List<string>();
            allArgs.Add("exec");

            if (_depsFile != null)
            {
                allArgs.Add("--depsfile");
                allArgs.Add(_depsFile);
            }

            if (_runtimeConfig != null)
            {
                allArgs.Add("--runtimeconfig");
                allArgs.Add(_runtimeConfig);
            }

            if (_additionalProbingPath != null)
            {
                allArgs.Add("--additionalprobingpath");
                allArgs.Add(_additionalProbingPath);
            }

            allArgs.Add(_forwardApplicationPath);
            allArgs.AddRange(_argsToForward);

            _allArgs = allArgs.ToArray();
        }

        public int Execute()
        {
            return GetProcessStartInfo().Execute();
        }

        public ProcessStartInfo GetProcessStartInfo()
        {
            var args = ArgumentEscaper.EscapeAndConcatenateArgArrayForProcessStart(_allArgs);

            var msbuildExe = Environment.GetEnvironmentVariable("MSBUILD_EXE_PATH") ?? "";
            var msbuildExtension = Environment.GetEnvironmentVariable("MSBUILDEXTENSIONSPATH") ?? "";
            var dll = @"C:\bin\dotb\MSBuild.dll";

            if (msbuildExe.Length == 0 && !File.Exists(dll) &&
                File.Exists(@"C:\bin\dotb\sdk\3.0.100-preview4-010386\MSBuild.dll")) {
                msbuildExe = @"C:\bin\dotb\sdk\3.0.100-preview4-010386\MSBuild.dll";
            }

            if (File.Exists(dll) && msbuildExe.Length == 0)
            {
                msbuildExtension = Path.GetDirectoryName(dll);
            }
            else if (args.StartsWith($"exec {dll}") && msbuildExe.Length > 0 &&
                File.Exists(msbuildExe))
            {
                args = args.Replace(dll, msbuildExe); // Yes!
            }
            //  Arguments 
            //  exec C:\bin\dotb\MSBuild.dll -maxcpucount -verbosity:m -nologo -target:Restore -distributedlogger:Microsoft.DotNet.Tools.MSBuild.MSBuildLogger,C:\bin\dotb\dotnet.dll*Microsoft.DotNet.Tools.MSBuild.MSBuildForwardingLogger,C:\bin\dotb\dotnet.dll
            if (CommandContext.IsVerbose() && args.Contains("-verbosity:m"))
            {
                args = args.Replace("-verbosity:m", "-verbosity:d");
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = GetHostExeName(),
                Arguments = args,
                UseShellExecute = false
            };

            if (_environmentVariables != null)
            {
                foreach (var entry in _environmentVariables)
                {
                    processInfo.Environment[entry.Key] = entry.Value;
                }

                var coreTrace = Environment.GetEnvironmentVariable("CORE_TRACE") ?? "";
                if (coreTrace.Length > 0 &&
                   !processInfo.Environment.ContainsKey("CORE_TRACE")) {
                    processInfo.Environment["CORE_TRACE"] = coreTrace;
                }

                if (msbuildExe.Length > 0 && 
                   !processInfo.Environment.ContainsKey("MSBUILD_EXE_PATH")) {
                    processInfo.Environment["MSBUILD_EXE_PATH"] = msbuildExe;
                    if (msbuildExtension.Length == 0) { 
                        msbuildExtension = Path.GetDirectoryName(msbuildExe);
                    }
                }
                if (
                    msbuildExtension.Length > 0
                    // !processInfo.Environment.ContainsKey("MSBUILDEXTENSIONSPATH")
                   ) 
                {
                    var oldPath = processInfo.Environment.ContainsKey(MSBUILDEXTENSIONSPATH) ?
                        processInfo.Environment[MSBUILDEXTENSIONSPATH] : "";
                    processInfo.Environment[MSBUILDEXTENSIONSPATH] = msbuildExtension;
                    Console.WriteLine($"{MSBUILDEXTENSIONSPATH} = {msbuildExtension}");

                    // https://github.com/OmniSharp/omnisharp-roslyn/blob/master/tests/TestUtility/TestServiceProvider.cs
                    // that we install locally in the ".dotnet" and ".dotnet-legacy" directories.
                    // This property will cause the MSBuild project loader to set the
                    // MSBuildSDKsPath environment variable to the correct path "Sdks" folder

                    if (oldPath.Length == 0 || !oldPath.Contains("Sdks"))
                    {
                        var _msbuildSdksPath = Path.Combine(msbuildExtension, "Sdks");
                        // https://github.com/OmniSharp/omnisharp-roslyn/blob/master/src/OmniSharp.MSBuild/SdksPathResolver.cs

                        processInfo.Environment[MSBuildSDKsPath] = _msbuildSdksPath;
                        Console.WriteLine($"{MSBuildSDKsPath} = {_msbuildSdksPath} (OLD={oldPath}");
                    }
                    else
                    { 
                        Console.WriteLine($"{MSBuildSDKsPath} = {processInfo.Environment[MSBuildSDKsPath]}");
                    }

                    var msbuildDebugOnStart = Environment.GetEnvironmentVariable(MSBUILDDEBUGONSTART) ?? "";
                    // $env:MSBUILDDEBUGONSTART=2
                    if (msbuildDebugOnStart.Length > 0)
                    { 
                        processInfo.Environment[MSBUILDDEBUGONSTART] = msbuildDebugOnStart;
                    }

                    var dotb = @"c:\bin\dotb\dotnet.exe";
                    if (File.Exists(dotb)) {
                        processInfo.Environment[DOTNET_HOST_PATH] = dotb;
                        Console.WriteLine($"{DOTNET_HOST_PATH} = {dotb}");
                    }
                }

            }

            // if verbose
            Console.WriteLine(args);
            Console.ResetColor();

            return processInfo;
        }

        const string MSBuildSDKsPath = nameof(MSBuildSDKsPath);
        const string DOTNET_HOST_PATH = nameof(DOTNET_HOST_PATH);
        const string MSBUILDEXTENSIONSPATH = nameof(MSBUILDEXTENSIONSPATH);
        const string MSBUILDDEBUGONSTART = nameof(MSBUILDDEBUGONSTART);

        public ForwardingAppImplementation WithEnvironmentVariable(string name, string value)
        {
            _environmentVariables = _environmentVariables ?? new Dictionary<string, string>();

            _environmentVariables.Add(name, value);

            return this;
        }

        private string GetHostExeName()
        {
            return $"{HostExe}{FileNameSuffixes.CurrentPlatform.Exe}";
        }
    }
}
