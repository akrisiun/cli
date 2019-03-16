using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Add.ProjectToProjectReference 
           // Tools.Add.PackageReference // .commands.dotnet_add.dotnet_add_reference
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_add.dotnet_add_reference.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string ProjectPathArgumentName => ResourceManager.GetString("ProjectPathArgumentName", Culture);
        internal static string ProjectPathArgumentDescription => ResourceManager.GetString("ProjectPathArgumentDescription", Culture);
        internal static string CmdFrameworkDescription => ResourceManager.GetString("CmdFrameworkDescription", Culture);
    }
}
