using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.BuildServer.Shutdown // Cli.commands.dotnet_buildserver.shutdown
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_buildserver.shutdown.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
        internal static string MSBuildOptionDescription => ResourceManager.GetString("MSBuildOptionDescription", Culture);
        internal static string VBCSCompilerOptionDescription => ResourceManager.GetString("VBCSCompilerOptionDescription", Culture);
        internal static string RazorOptionDescription => ResourceManager.GetString("RazorOptionDescription", Culture);
        internal static string ShuttingDownServer => ResourceManager.GetString("ShuttingDownServer", Culture);
        internal static string ShuttingDownServerWithPid => ResourceManager.GetString("ShuttingDownServerWithPid", Culture);
        internal static string ShutDownSucceeded => ResourceManager.GetString("ShutDownSucceeded", Culture);
        internal static string ShutDownSucceededWithPid => ResourceManager.GetString("ShutDownSucceededWithPid", Culture);
        internal static string ShutDownFailed => ResourceManager.GetString("ShutDownFailed", Culture);
        internal static string ShutDownFailedWithPid => ResourceManager.GetString("ShutDownFailedWithPid", Culture);
        internal static string NoServersToShutdown => ResourceManager.GetString("NoServersToShutdown", Culture);
    }
}
