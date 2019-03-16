using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Tool.List // .Cli.commands.dotnet_tool.list
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_tool.list.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
        internal static string GlobalOptionDescription => ResourceManager.GetString("GlobalOptionDescription", Culture);
        internal static string ToolPathOptionName => ResourceManager.GetString("ToolPathOptionName", Culture);
        internal static string ToolPathOptionDescription => ResourceManager.GetString("ToolPathOptionDescription", Culture);
        internal static string NeedGlobalOrToolPath => ResourceManager.GetString("NeedGlobalOrToolPath", Culture);
        internal static string GlobalAndToolPathConflict => ResourceManager.GetString("GlobalAndToolPathConflict", Culture);
        internal static string InvalidPackageWarning => ResourceManager.GetString("InvalidPackageWarning", Culture);
        internal static string PackageIdColumn => ResourceManager.GetString("PackageIdColumn", Culture);
        internal static string VersionColumn => ResourceManager.GetString("VersionColumn", Culture);
        internal static string CommandsColumn => ResourceManager.GetString("CommandsColumn", Culture);
        internal static string InvalidToolPathOption => ResourceManager.GetString("InvalidToolPathOption", Culture);
    }
}
