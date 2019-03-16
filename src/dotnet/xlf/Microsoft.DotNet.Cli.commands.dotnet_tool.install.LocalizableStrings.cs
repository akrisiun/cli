using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Tool.Install // .Cli.commands.dotnet_tool.install
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_tool.install.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string PackageIdArgumentName => ResourceManager.GetString("PackageIdArgumentName", Culture);
        internal static string PackageIdArgumentDescription => ResourceManager.GetString("PackageIdArgumentDescription", Culture);
        internal static string SpecifyExactlyOnePackageId => ResourceManager.GetString("SpecifyExactlyOnePackageId", Culture);
        internal static string VersionOptionName => ResourceManager.GetString("VersionOptionName", Culture);
        internal static string VersionOptionDescription => ResourceManager.GetString("VersionOptionDescription", Culture);
        internal static string AddSourceOptionName => ResourceManager.GetString("AddSourceOptionName", Culture);
        internal static string AddSourceOptionDescription => ResourceManager.GetString("AddSourceOptionDescription", Culture);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
        internal static string ConfigFileOptionName => ResourceManager.GetString("ConfigFileOptionName", Culture);
        internal static string ConfigFileOptionDescription => ResourceManager.GetString("ConfigFileOptionDescription", Culture);
        internal static string FrameworkOptionName => ResourceManager.GetString("FrameworkOptionName", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string NuGetConfigurationFileDoesNotExist => ResourceManager.GetString("NuGetConfigurationFileDoesNotExist", Culture);
        internal static string InstallationSucceeded => ResourceManager.GetString("InstallationSucceeded", Culture);
        internal static string GlobalOptionDescription => ResourceManager.GetString("GlobalOptionDescription", Culture);
        internal static string InstallFullCommandNameLocalized => ResourceManager.GetString("InstallFullCommandNameLocalized", Culture);
        internal static string InvalidToolConfiguration => ResourceManager.GetString("InvalidToolConfiguration", Culture);
        internal static string ToolInstallationFailed => ResourceManager.GetString("ToolInstallationFailed", Culture);
        internal static string ToolInstallationFailedWithRestoreGuidance => ResourceManager.GetString("ToolInstallationFailedWithRestoreGuidance", Culture);
        internal static string ToolInstallationFailedContactAuthor => ResourceManager.GetString("ToolInstallationFailedContactAuthor", Culture);
        internal static string ToolInstallationRestoreFailed => ResourceManager.GetString("ToolInstallationRestoreFailed", Culture);
        internal static string ToolAlreadyInstalled => ResourceManager.GetString("ToolAlreadyInstalled", Culture);
        internal static string FailedToCreateToolShim => ResourceManager.GetString("FailedToCreateToolShim", Culture);
        internal static string InvalidNuGetVersionRange => ResourceManager.GetString("InvalidNuGetVersionRange", Culture);
        internal static string InstallToolCommandNeedGlobalOrToolPath => ResourceManager.GetString("InstallToolCommandNeedGlobalOrToolPath", Culture);
        internal static string InstallToolCommandInvalidGlobalAndToolPath => ResourceManager.GetString("InstallToolCommandInvalidGlobalAndToolPath", Culture);
        internal static string ToolPathOptionName => ResourceManager.GetString("ToolPathOptionName", Culture);
        internal static string ToolPathOptionDescription => ResourceManager.GetString("ToolPathOptionDescription", Culture);
    }
}
