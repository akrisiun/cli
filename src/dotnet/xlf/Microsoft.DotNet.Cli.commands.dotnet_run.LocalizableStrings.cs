using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Run // .dotnet_run
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_run.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CommandOptionNoBuildDescription => ResourceManager.GetString("CommandOptionNoBuildDescription", Culture);
        internal static string CommandOptionFrameworkDescription => ResourceManager.GetString("CommandOptionFrameworkDescription", Culture);
        internal static string CommandOptionProjectDescription => ResourceManager.GetString("CommandOptionProjectDescription", Culture);
        internal static string CommandOptionLaunchProfileDescription => ResourceManager.GetString("CommandOptionLaunchProfileDescription", Culture);
        internal static string CommandOptionNoLaunchProfileDescription => ResourceManager.GetString("CommandOptionNoLaunchProfileDescription", Culture);
        internal static string ConfigurationOptionDescription => ResourceManager.GetString("ConfigurationOptionDescription", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string RunCommandException => ResourceManager.GetString("RunCommandException", Culture);
        internal static string RunCommandExceptionUnableToRunSpecifyFramework => ResourceManager.GetString("RunCommandExceptionUnableToRunSpecifyFramework", Culture);
        internal static string RunCommandExceptionUnableToRun => ResourceManager.GetString("RunCommandExceptionUnableToRun", Culture);
        internal static string RunCommandExceptionNoProjects => ResourceManager.GetString("RunCommandExceptionNoProjects", Culture);
        internal static string RunCommandExceptionMultipleProjects => ResourceManager.GetString("RunCommandExceptionMultipleProjects", Culture);
        internal static string RunCommandAdditionalArgsHelpText => ResourceManager.GetString("RunCommandAdditionalArgsHelpText", Culture);
        internal static string RunCommandExceptionCouldNotLocateALaunchSettingsFile => ResourceManager.GetString("RunCommandExceptionCouldNotLocateALaunchSettingsFile", Culture);
        internal static string RunCommandExceptionCouldNotApplyLaunchSettings => ResourceManager.GetString("RunCommandExceptionCouldNotApplyLaunchSettings", Culture);
        internal static string DefaultLaunchProfileDisplayName => ResourceManager.GetString("DefaultLaunchProfileDisplayName", Culture);
        internal static string UsingLaunchSettingsFromMessage => ResourceManager.GetString("UsingLaunchSettingsFromMessage", Culture);
        internal static string LaunchProfileIsNotAJsonObject => ResourceManager.GetString("LaunchProfileIsNotAJsonObject", Culture);
        internal static string LaunchProfileHandlerCannotBeLocated => ResourceManager.GetString("LaunchProfileHandlerCannotBeLocated", Culture);
        internal static string UsableLaunchProfileCannotBeLocated => ResourceManager.GetString("UsableLaunchProfileCannotBeLocated", Culture);
        internal static string UnexpectedExceptionProcessingLaunchSettings => ResourceManager.GetString("UnexpectedExceptionProcessingLaunchSettings", Culture);
        internal static string LaunchProfilesCollectionIsNotAJsonObject => ResourceManager.GetString("LaunchProfilesCollectionIsNotAJsonObject", Culture);
        internal static string DeserializationExceptionMessage => ResourceManager.GetString("DeserializationExceptionMessage", Culture);
        internal static string RunCommandSpecifiecFileIsNotAValidProject => ResourceManager.GetString("RunCommandSpecifiecFileIsNotAValidProject", Culture);
    }
}
