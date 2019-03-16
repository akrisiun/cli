using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Cli.BuildServer
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.BuildServer.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string MSBuildServer => ResourceManager.GetString("MSBuildServer", Culture);
        internal static string VBCSCompilerServer => ResourceManager.GetString("VBCSCompilerServer", Culture);
        internal static string RazorServer => ResourceManager.GetString("RazorServer", Culture);
        internal static string ShutdownCommandFailed => ResourceManager.GetString("ShutdownCommandFailed", Culture);
        internal static string FailedToReadPidFile => ResourceManager.GetString("FailedToReadPidFile", Culture);
    }
}
