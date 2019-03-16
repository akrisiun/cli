using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Remove.PackageReference //  .dotnet_remove.dotnet_remove_package
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_remove.dotnet_remove_package.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string AppHelpText => ResourceManager.GetString("AppHelpText", Culture);
        internal static string SpecifyExactlyOnePackageReference => ResourceManager.GetString("SpecifyExactlyOnePackageReference", Culture);
    }
}
