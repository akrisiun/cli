using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Help // Microsoft.DotNet.Cli.commands.dotnet_help
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_help.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string Usage => ResourceManager.GetString("Usage", Culture);
        internal static string Arguments => ResourceManager.GetString("Arguments", Culture);
        internal static string CommandDefinition => ResourceManager.GetString("CommandDefinition", Culture);
        internal static string ArgumentsDefinition => ResourceManager.GetString("ArgumentsDefinition", Culture);
        internal static string HostOptionsDefinition => ResourceManager.GetString("HostOptionsDefinition", Culture);
        internal static string OptionsDescription => ResourceManager.GetString("OptionsDescription", Culture);
        internal static string DiagnosticsDefinition => ResourceManager.GetString("DiagnosticsDefinition", Culture);
        internal static string SDKCommandUsageDescription => ResourceManager.GetString("SDKCommandUsageDescription", Culture);
        internal static string ExecutionUsageDescription => ResourceManager.GetString("ExecutionUsageDescription", Culture);
        internal static string HelpDefinition => ResourceManager.GetString("HelpDefinition", Culture);
        internal static string HostOptions => ResourceManager.GetString("HostOptions", Culture);
        internal static string VersionDescription => ResourceManager.GetString("VersionDescription", Culture);
        internal static string InfoDescription => ResourceManager.GetString("InfoDescription", Culture);
        internal static string Commands => ResourceManager.GetString("Commands", Culture);
        internal static string NewDefinition => ResourceManager.GetString("NewDefinition", Culture);
        internal static string RestoreDefinition => ResourceManager.GetString("RestoreDefinition", Culture);
        internal static string BuildDefinition => ResourceManager.GetString("BuildDefinition", Culture);
        internal static string PublishDefinition => ResourceManager.GetString("PublishDefinition", Culture);
        internal static string RunDefinition => ResourceManager.GetString("RunDefinition", Culture);
        internal static string TestDefinition => ResourceManager.GetString("TestDefinition", Culture);
        internal static string PackDefinition => ResourceManager.GetString("PackDefinition", Culture);
        internal static string MigrateDefinition => ResourceManager.GetString("MigrateDefinition", Culture);
        internal static string StoreDefinition => ResourceManager.GetString("StoreDefinition", Culture);
        internal static string ProjectModificationCommands => ResourceManager.GetString("ProjectModificationCommands", Culture);
        internal static string AddDefinition => ResourceManager.GetString("AddDefinition", Culture);
        internal static string RemoveDefinition => ResourceManager.GetString("RemoveDefinition", Culture);
        internal static string ListDefinition => ResourceManager.GetString("ListDefinition", Culture);
        internal static string AdvancedCommands => ResourceManager.GetString("AdvancedCommands", Culture);
        internal static string NugetDefinition => ResourceManager.GetString("NugetDefinition", Culture);
        internal static string MsBuildDefinition => ResourceManager.GetString("MsBuildDefinition", Culture);
        internal static string VsTestDefinition => ResourceManager.GetString("VsTestDefinition", Culture);
        internal static string CleanDefinition => ResourceManager.GetString("CleanDefinition", Culture);
        internal static string SlnDefinition => ResourceManager.GetString("SlnDefinition", Culture);
        internal static string CommandDoesNotExist => ResourceManager.GetString("CommandDoesNotExist", Culture);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CommandArgumentName => ResourceManager.GetString("CommandArgumentName", Culture);
        internal static string CommandArgumentDescription => ResourceManager.GetString("CommandArgumentDescription", Culture);
        internal static string PathToApplicationDefinition => ResourceManager.GetString("PathToApplicationDefinition", Culture);
        internal static string SDKVersionCommandDefinition => ResourceManager.GetString("SDKVersionCommandDefinition", Culture);
        internal static string SDKInfoCommandDefinition => ResourceManager.GetString("SDKInfoCommandDefinition", Culture);
        internal static string SDKListSdksCommandDefinition => ResourceManager.GetString("SDKListSdksCommandDefinition", Culture);
        internal static string SDKListRuntimesCommandDefinition => ResourceManager.GetString("SDKListRuntimesCommandDefinition", Culture);
        internal static string SDKDiagnosticsCommandDefinition => ResourceManager.GetString("SDKDiagnosticsCommandDefinition", Culture);
        internal static string RunDotnetCommandHelpForMore => ResourceManager.GetString("RunDotnetCommandHelpForMore", Culture);
        internal static string AdditionalprobingpathDefinition => ResourceManager.GetString("AdditionalprobingpathDefinition", Culture);
        internal static string DepsfilDefinition => ResourceManager.GetString("DepsfilDefinition", Culture);
        internal static string RuntimeconfigDefinition => ResourceManager.GetString("RuntimeconfigDefinition", Culture);
        internal static string FxVersionDefinition => ResourceManager.GetString("FxVersionDefinition", Culture);
        internal static string RollForwardOnNoCandidateFxDefinition => ResourceManager.GetString("RollForwardOnNoCandidateFxDefinition", Culture);
        internal static string AdditionalDeps => ResourceManager.GetString("AdditionalDeps", Culture);
        internal static string ToolDefinition => ResourceManager.GetString("ToolDefinition", Culture);
        internal static string BuildServerDefinition => ResourceManager.GetString("BuildServerDefinition", Culture);
        internal static string FsiDefinition => ResourceManager.GetString("FsiDefinition", Culture);
        internal static string DevCertsDefinition => ResourceManager.GetString("DevCertsDefinition", Culture);
        internal static string EfDefinition => ResourceManager.GetString("EfDefinition", Culture);
        internal static string SqlCacheDefinition => ResourceManager.GetString("SqlCacheDefinition", Culture);
        internal static string UserSecretsDefinition => ResourceManager.GetString("UserSecretsDefinition", Culture);
        internal static string WatchDefinition => ResourceManager.GetString("WatchDefinition", Culture);
        internal static string AdditionalTools => ResourceManager.GetString("AdditionalTools", Culture);
    }
}
