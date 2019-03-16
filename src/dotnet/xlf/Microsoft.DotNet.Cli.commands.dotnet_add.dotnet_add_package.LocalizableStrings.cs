using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Add.PackageReference // commands.dotnet_add.dotnet_add_package
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_add.dotnet_add_package.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CmdPackageDescription => ResourceManager.GetString("CmdPackageDescription", Culture);
        internal static string SpecifyExactlyOnePackageReference => ResourceManager.GetString("SpecifyExactlyOnePackageReference", Culture);
        internal static string CmdFrameworkDescription => ResourceManager.GetString("CmdFrameworkDescription", Culture);
        internal static string CmdNoRestoreDescription => ResourceManager.GetString("CmdNoRestoreDescription", Culture);
        internal static string CmdSourceDescription => ResourceManager.GetString("CmdSourceDescription", Culture);
        internal static string CmdPackageDirectoryDescription => ResourceManager.GetString("CmdPackageDirectoryDescription", Culture);
        internal static string CmdVersionDescription => ResourceManager.GetString("CmdVersionDescription", Culture);
        internal static string CmdDGFileException => ResourceManager.GetString("CmdDGFileException", Culture);
        internal static string CmdPackage => ResourceManager.GetString("CmdPackage", Culture);
        internal static string CmdVersion => ResourceManager.GetString("CmdVersion", Culture);
        internal static string CmdFramework => ResourceManager.GetString("CmdFramework", Culture);
        internal static string CmdSource => ResourceManager.GetString("CmdSource", Culture);
        internal static string CmdPackageDirectory => ResourceManager.GetString("CmdPackageDirectory", Culture);
        internal static string CmdDGFileIOException => ResourceManager.GetString("CmdDGFileIOException", Culture);
    }
}
