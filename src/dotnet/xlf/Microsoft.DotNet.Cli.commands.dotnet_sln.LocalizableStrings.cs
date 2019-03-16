using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Sln // .dotnet_sln
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_sln.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string SolutionArgumentName => ResourceManager.GetString("SolutionArgumentName", Culture);
        internal static string SolutionArgumentDescription => ResourceManager.GetString("SolutionArgumentDescription", Culture);
        internal static string AppHelpText => ResourceManager.GetString("AppHelpText", Culture);
        internal static string AddAppFullName => ResourceManager.GetString("AddAppFullName", Culture);
        internal static string AddProjectPathArgumentName => ResourceManager.GetString("AddProjectPathArgumentName", Culture);
        internal static string AddProjectPathArgumentDescription => ResourceManager.GetString("AddProjectPathArgumentDescription", Culture);
        internal static string RemoveProjectPathArgumentName => ResourceManager.GetString("RemoveProjectPathArgumentName", Culture);
        internal static string RemoveProjectPathArgumentDescription => ResourceManager.GetString("RemoveProjectPathArgumentDescription", Culture);
        internal static string RemoveAppFullName => ResourceManager.GetString("RemoveAppFullName", Culture);
        internal static string RemoveSubcommandHelpText => ResourceManager.GetString("RemoveSubcommandHelpText", Culture);
        internal static string ListAppFullName => ResourceManager.GetString("ListAppFullName", Culture);
        internal static string ListSubcommandHelpText => ResourceManager.GetString("ListSubcommandHelpText", Culture);
        internal static string ProjectsHeader => ResourceManager.GetString("ProjectsHeader", Culture);
    }
}
