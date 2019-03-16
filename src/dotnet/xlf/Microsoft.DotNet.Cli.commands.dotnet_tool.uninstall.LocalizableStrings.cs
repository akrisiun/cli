using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Tool.Uninstall // .dotnet_tool.uninstall
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_tool.uninstall.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string PackageIdArgumentName => ResourceManager.GetString("PackageIdArgumentName", Culture);
        internal static string PackageIdArgumentDescription => ResourceManager.GetString("PackageIdArgumentDescription", Culture);
        internal static string SpecifyExactlyOnePackageId => ResourceManager.GetString("SpecifyExactlyOnePackageId", Culture);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
        internal static string GlobalOptionDescription => ResourceManager.GetString("GlobalOptionDescription", Culture);
        internal static string UninstallSucceeded => ResourceManager.GetString("UninstallSucceeded", Culture);
        internal static string ToolNotInstalled => ResourceManager.GetString("ToolNotInstalled", Culture);
        internal static string ToolHasMultipleVersionsInstalled => ResourceManager.GetString("ToolHasMultipleVersionsInstalled", Culture);
        internal static string FailedToUninstallTool => ResourceManager.GetString("FailedToUninstallTool", Culture);
        internal static string UninstallToolCommandNeedGlobalOrToolPath => ResourceManager.GetString("UninstallToolCommandNeedGlobalOrToolPath", Culture);
        internal static string ToolPathOptionName => ResourceManager.GetString("ToolPathOptionName", Culture);
        internal static string ToolPathOptionDescription => ResourceManager.GetString("ToolPathOptionDescription", Culture);
        internal static string UninstallToolCommandInvalidGlobalAndToolPath => ResourceManager.GetString("UninstallToolCommandInvalidGlobalAndToolPath", Culture);
        internal static string InvalidToolPathOption => ResourceManager.GetString("InvalidToolPathOption", Culture);
    }
}
