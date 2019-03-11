using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace NugetLib
{
    public class Load
    {
        public static void Main() => Assemblies();

        public static string[] Dlls = new string[] {
            "MSBuild",
            "Newtonsoft.Json",
            "NuGet.Frameworks",
            "NuGet.Build.Tasks",
			"Microsoft.Build.Framework",
			"Microsoft.Build",
            "NuGet.CommandLine.XPlat",
            "NuGet.Commands",
            "NuGet.Common",
            "NuGet.Configuration",
            "NuGet.Credentials",
            "NuGet.DependencyResolver.Core",
            "NuGet.LibraryModel",
            "NuGet.Packaging",
            "NuGet.Packaging.Core",
            "NuGet.ProjectModel",
            "NuGet.Protocol",
            "NuGet.Versioning"
        };

        public static List<Assembly> List { get; set; }
        public static bool IsVerbose {get; set;}
        public static void Assemblies()
        {
            List = new List<Assembly>();
            var args = string.Join(" ", Environment.GetCommandLineArgs());
            IsVerbose = args.Contains("-v d") || args.Contains("--debug")  || args.Contains("--info");

            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var msExt = Environment.GetEnvironmentVariable("MSBUILDEXTENSIONSPATH") ?? "";
            if (msExt.Length > 0)
            {
                baseDir = msExt;
                IsVerbose = true;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"env:MSBUILDEXTENSIONSPATH: {baseDir}");
                Console.WriteLine($"env:MSBuildSDKsPath: {Environment.GetEnvironmentVariable("MSBuildSDKsPath")}");
                Console.ResetColor();
            }

            int i = -1;
            foreach (var dll in Dlls)
            {
                i++;
                string file = Path.Combine(baseDir, dll + ".dll");
                if (File.Exists(file))
                {
                    try
                    {
                        Assembly asm = Assembly.LoadFile(file);
                        List.Add(asm);
                        if (IsVerbose || i < 6)
                        {
                            Console.WriteLine($"{asm.FullName} | {asm.Location}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed load {file}: {ex}");
                    }
                }
                else
                { 
                    Console.WriteLine($"No file load {file}");
                }
            }
       }

        public static Assembly MSBuildApp { 
            get {
                return typeof(Microsoft.Build.CommandLine.MSBuildApp).Assembly;
            }
        }

        public static int Build(string[] args)
        {
            int ret = 0;
            var ret1 = Microsoft.Build.CommandLine.MSBuildApp.Execute(args);
            if (ret1 != Microsoft.Build.CommandLine.MSBuildApp.ExitType.Success)
            {
                ret = (int)ret1;
            }

            return ret;
        }
 
    }
}
