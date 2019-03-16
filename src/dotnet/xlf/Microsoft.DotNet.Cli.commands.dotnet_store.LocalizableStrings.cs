using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Store // .dotnet_store
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_store.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string ProjectManifest => ResourceManager.GetString("ProjectManifest", Culture);
        internal static string ProjectManifestDescription => ResourceManager.GetString("ProjectManifestDescription", Culture);
        internal static string OutputOption => ResourceManager.GetString("OutputOption", Culture);
        internal static string OutputOptionDescription => ResourceManager.GetString("OutputOptionDescription", Culture);
        internal static string FrameworkVersionOption => ResourceManager.GetString("FrameworkVersionOption", Culture);
        internal static string FrameworkVersionOptionDescription => ResourceManager.GetString("FrameworkVersionOptionDescription", Culture);
        internal static string SkipOptimizationOptionDescription => ResourceManager.GetString("SkipOptimizationOptionDescription", Culture);
        internal static string SkipSymbolsOptionDescription => ResourceManager.GetString("SkipSymbolsOptionDescription", Culture);
        internal static string IntermediateWorkingDirOption => ResourceManager.GetString("IntermediateWorkingDirOption", Culture);
        internal static string IntermediateWorkingDirOptionDescription => ResourceManager.GetString("IntermediateWorkingDirOptionDescription", Culture);
        internal static string SpecifyManifests => ResourceManager.GetString("SpecifyManifests", Culture);
        internal static string IntermediateDirExists => ResourceManager.GetString("IntermediateDirExists", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string RuntimeOptionDescription => ResourceManager.GetString("RuntimeOptionDescription", Culture);
    }
}
