using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Restore //.dotnet_restore
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_restore.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CmdArgument => ResourceManager.GetString("CmdArgument", Culture);
        internal static string CmdArgumentDescription => ResourceManager.GetString("CmdArgumentDescription", Culture);
        internal static string CmdSourceOption => ResourceManager.GetString("CmdSourceOption", Culture);
        internal static string CmdSourceOptionDescription => ResourceManager.GetString("CmdSourceOptionDescription", Culture);
        internal static string CmdRuntimeOption => ResourceManager.GetString("CmdRuntimeOption", Culture);
        internal static string CmdRuntimeOptionDescription => ResourceManager.GetString("CmdRuntimeOptionDescription", Culture);
        internal static string CmdPackagesOption => ResourceManager.GetString("CmdPackagesOption", Culture);
        internal static string CmdPackagesOptionDescription => ResourceManager.GetString("CmdPackagesOptionDescription", Culture);
        internal static string CmdDisableParallelOptionDescription => ResourceManager.GetString("CmdDisableParallelOptionDescription", Culture);
        internal static string CmdConfigFileOption => ResourceManager.GetString("CmdConfigFileOption", Culture);
        internal static string CmdConfigFileOptionDescription => ResourceManager.GetString("CmdConfigFileOptionDescription", Culture);
        internal static string CmdNoCacheOptionDescription => ResourceManager.GetString("CmdNoCacheOptionDescription", Culture);
        internal static string CmdIgnoreFailedSourcesOptionDescription => ResourceManager.GetString("CmdIgnoreFailedSourcesOptionDescription", Culture);
        internal static string CmdNoDependenciesOptionDescription => ResourceManager.GetString("CmdNoDependenciesOptionDescription", Culture);
        internal static string CmdForceRestoreOptionDescription => ResourceManager.GetString("CmdForceRestoreOptionDescription", Culture);
        internal static string CmdInteractiveRestoreOptionDescription => ResourceManager.GetString("CmdInteractiveRestoreOptionDescription", Culture);
        internal static string CmdLockedModeOptionDescription => ResourceManager.GetString("CmdLockedModeOptionDescription", Culture);
        internal static string CmdLockFilePathOption => ResourceManager.GetString("CmdLockFilePathOption", Culture);
        internal static string CmdLockFilePathOptionDescription => ResourceManager.GetString("CmdLockFilePathOptionDescription", Culture);
        internal static string CmdReevaluateOptionDescription => ResourceManager.GetString("CmdReevaluateOptionDescription", Culture);
        internal static string CmdUseLockFileOptionDescription => ResourceManager.GetString("CmdUseLockFileOptionDescription", Culture);
    }
}
