using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Publish // .dotnet_publish
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_publish.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string FrameworkOption => ResourceManager.GetString("FrameworkOption", Culture);
        internal static string OutputOption => ResourceManager.GetString("OutputOption", Culture);
        internal static string OutputOptionDescription => ResourceManager.GetString("OutputOptionDescription", Culture);
        internal static string ManifestOption => ResourceManager.GetString("ManifestOption", Culture);
        internal static string ManifestOptionDescription => ResourceManager.GetString("ManifestOptionDescription", Culture);
        internal static string SelfContainedOptionDescription => ResourceManager.GetString("SelfContainedOptionDescription", Culture);
        internal static string NoBuildOptionDescription => ResourceManager.GetString("NoBuildOptionDescription", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string RuntimeOptionDescription => ResourceManager.GetString("RuntimeOptionDescription", Culture);
        internal static string ConfigurationOptionDescription => ResourceManager.GetString("ConfigurationOptionDescription", Culture);
    }
}
