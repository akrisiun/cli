// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.DotNet.Cli;
using Microsoft.DotNet.Cli.CommandLine;
using System.Diagnostics;
using Microsoft.DotNet.Cli.Telemetry;
using Microsoft.DotNet.Cli.Utils;

namespace Microsoft.DotNet.Tools.MSBuild
{
    public class MSBuildForwardingApp
    {
        internal const string TelemetrySessionIdEnvironmentVariableName = "DOTNET_CLI_TELEMETRY_SESSIONID";

        private MSBuildForwardingAppWithoutLogging _forwardingAppWithoutLogging;

        private static IEnumerable<string> ConcatTelemetryLogger(IEnumerable<string> argsToForward)
        {
            if (Telemetry.CurrentSessionId != null)
            {
                try
                {
                    Type loggerType = typeof(MSBuildLogger);
                    Type forwardingLoggerType = typeof(MSBuildForwardingLogger);

                    return argsToForward
                        .Concat(new[]
                        {
                            $"-distributedlogger:{loggerType.FullName},{loggerType.GetTypeInfo().Assembly.Location}*{forwardingLoggerType.FullName},{forwardingLoggerType.GetTypeInfo().Assembly.Location}"
                        });
                }
                catch (Exception)
                {
                    // Exceptions during telemetry shouldn't cause anything else to fail
                }
            }
            return argsToForward;
        }

        public MSBuildForwardingApp(IEnumerable<string> argsToForward, string msbuildPath = null)
        {
            _forwardingAppWithoutLogging = new MSBuildForwardingAppWithoutLogging(
                ConcatTelemetryLogger(argsToForward),
                msbuildPath);
        }

        public ProcessStartInfo GetProcessStartInfo()
        {
            var ret = _forwardingAppWithoutLogging.GetProcessStartInfo();

            ret.Environment[TelemetrySessionIdEnvironmentVariableName] = Telemetry.CurrentSessionId;

            return ret;
        }

        public static bool Fast { get; set; }

        public virtual int Execute()
        {
            if (Fast) {
                return GetProcessStartInfo().Execute();
            }

            int ret;
            var proc = GetProcessStartInfo();
            var line = string.Join(" ", Environment.GetCommandLineArgs());
            var arguments = proc.Arguments;
            if (
               (line.Contains("-v d") || line.Contains("-v n")) && 
               arguments.Contains("-verbosity:"))
            {
                if (line.Contains("-v d"))
                    arguments = arguments.Replace("-verbosity:m", "-verbosity:d");
                if (line.Contains("-v n"))
                    arguments = arguments.Replace("-verbosity:m", "-verbosity:n");
            }
            string[] args1 = arguments.Split(new char[] { ' ' });

            if (args1.Length > 2 && 
               (args1[0] == "exec" || line.Contains("--debug") || CommandContext.IsVerbose())
               ) 
            {
                string[] arg2 = new string[] { };
                Array.Resize(ref arg2, args1.Length - 2);
                Array.Copy(args1, 2, arg2, 0, args1.Length - 2);

                Assembly msb = NugetLib.Load.MSBuildApp;
                Console.WriteLine($"MSB dotnet {msb.FullName}");

                ret = NugetLib.Load.Build(arg2);

            } else {
                ret = proc.Execute();
            }

            return ret;
        }
    }
}
