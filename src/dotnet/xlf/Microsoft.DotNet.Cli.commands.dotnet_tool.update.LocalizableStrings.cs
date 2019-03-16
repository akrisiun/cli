using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Tool.Update // .dotnet_tool.update
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_tool.update.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string PackageIdArgumentName => ResourceManager.GetString("PackageIdArgumentName", Culture);
        internal static string PackageIdArgumentDescription => ResourceManager.GetString("PackageIdArgumentDescription", Culture);
        internal static string SpecifyExactlyOnePackageId => ResourceManager.GetString("SpecifyExactlyOnePackageId", Culture);
        internal static string VersionOptionDescription => ResourceManager.GetString("VersionOptionDescription", Culture);
        internal static string AddSourceOptionDescription => ResourceManager.GetString("AddSourceOptionDescription", Culture);
        internal static string AddSourceOptionName => ResourceManager.GetString("AddSourceOptionName", Culture);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
        internal static string ConfigFileOptionName => ResourceManager.GetString("ConfigFileOptionName", Culture);
        internal static string ConfigFileOptionDescription => ResourceManager.GetString("ConfigFileOptionDescription", Culture);
        internal static string FrameworkOptionName => ResourceManager.GetString("FrameworkOptionName", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string NuGetConfigurationFileDoesNotExist => ResourceManager.GetString("NuGetConfigurationFileDoesNotExist", Culture);
        internal static string UpdateSucceeded => ResourceManager.GetString("UpdateSucceeded", Culture);
        internal static string GlobalOptionDescription => ResourceManager.GetString("GlobalOptionDescription", Culture);
        internal static string UpdateFullCommandNameLocalized => ResourceManager.GetString("UpdateFullCommandNameLocalized", Culture);
        internal static string UpdateToolCommandNeedGlobalOrToolPath => ResourceManager.GetString("UpdateToolCommandNeedGlobalOrToolPath", Culture);
        internal static string UpdateToolCommandInvalidGlobalAndToolPath => ResourceManager.GetString("UpdateToolCommandInvalidGlobalAndToolPath", Culture);
        internal static string ToolPathOptionName => ResourceManager.GetString("ToolPathOptionName", Culture);
        internal static string ToolPathOptionDescription => ResourceManager.GetString("ToolPathOptionDescription", Culture);
        internal static string ToolHasMultipleVersionsInstalled => ResourceManager.GetString("ToolHasMultipleVersionsInstalled", Culture);
        internal static string ToolNotInstalled => ResourceManager.GetString("ToolNotInstalled", Culture);
        internal static string UpdateSucceededVersionNoChange => ResourceManager.GetString("UpdateSucceededVersionNoChange", Culture);
        internal static string UpdateToolFailed => ResourceManager.GetString("UpdateToolFailed", Culture);
    }
}
