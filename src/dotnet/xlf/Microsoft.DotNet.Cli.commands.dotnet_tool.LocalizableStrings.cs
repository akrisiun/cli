using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Tool // .Cli.commands.dotnet_tool
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_tool.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string InstallFullCommandNameLocalized => ResourceManager.GetString("InstallFullCommandNameLocalized", Culture);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
    }
}
