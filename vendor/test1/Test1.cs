using System;
// using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RunTests
{
    [TestClass]
    public class Test1
    {
        // [Fact]
        [TestMethod]
        public void Info1() {
            Console.WriteLine("Testing info");
            string[] args = new string[] { "--info" };
            var ret = Microsoft.DotNet.Cli.Program.ProcessArgs(args);
            
            Assert.AreEqual(0, ret);
        }

        // [Fact]
        [TestMethod]
        public void Build1() {
            Console.WriteLine("Testing build NugetLib");

            // dotnet-cli\artifacts\bin\btest1\Debug\netcoreapp3.0\
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            string[] args = new string[] {
                // "--debug",
                "build",
                $"{dir}/../../../../../vendor/NugetLib",
                "-v",
                "d"
            };

            Environment.SetEnvironmentVariable("MSBUILDDONOTLAUNCHDEBUGGER", "1");
            var ret = Microsoft.DotNet.Cli.Program.ProcessArgs(args);
            Assert.AreEqual(0, ret);
        }
    }
}
