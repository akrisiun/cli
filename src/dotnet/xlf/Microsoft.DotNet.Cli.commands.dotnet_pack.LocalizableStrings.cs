using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Pack // .dotnet_pack
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_pack.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CmdOutputDir => ResourceManager.GetString("CmdOutputDir", Culture);
        internal static string CmdOutputDirDescription => ResourceManager.GetString("CmdOutputDirDescription", Culture);
        internal static string CmdNoBuildOptionDescription => ResourceManager.GetString("CmdNoBuildOptionDescription", Culture);
        internal static string CmdIncludeSymbolsDescription => ResourceManager.GetString("CmdIncludeSymbolsDescription", Culture);
        internal static string CmdIncludeSourceDescription => ResourceManager.GetString("CmdIncludeSourceDescription", Culture);
        internal static string CmdServiceableDescription => ResourceManager.GetString("CmdServiceableDescription", Culture);
        internal static string CmdArgumentProject => ResourceManager.GetString("CmdArgumentProject", Culture);
        internal static string CmdArgumentDescription => ResourceManager.GetString("CmdArgumentDescription", Culture);
        internal static string ConfigurationOptionDescription => ResourceManager.GetString("ConfigurationOptionDescription", Culture);
    }
}
