using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.List.ProjectToProjectReferences // .dotnet_list.dotnet_list_reference
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_list.dotnet_list_reference.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string NoReferencesFound => ResourceManager.GetString("NoReferencesFound", Culture);
    }
}
