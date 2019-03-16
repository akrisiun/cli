using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Build // .dotnet_build
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_build.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string NoDependenciesOptionDescription => ResourceManager.GetString("NoDependenciesOptionDescription", Culture);
        internal static string NoIncrementialOptionDescription => ResourceManager.GetString("NoIncrementialOptionDescription", Culture);
        internal static string OutputOptionDescription => ResourceManager.GetString("OutputOptionDescription", Culture);
        internal static string OutputOptionName => ResourceManager.GetString("OutputOptionName", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string RuntimeOptionDescription => ResourceManager.GetString("RuntimeOptionDescription", Culture);
        internal static string ConfigurationOptionDescription => ResourceManager.GetString("ConfigurationOptionDescription", Culture);
    }
}
