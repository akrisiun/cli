using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Cli.Utils
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.Utils.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string MalformedText => ResourceManager.GetString("MalformedText", Culture);
        internal static string BuildOutputPathDoesNotExist => ResourceManager.GetString("BuildOutputPathDoesNotExist", Culture);
        internal static string AttemptingToFindCommand => ResourceManager.GetString("AttemptingToFindCommand", Culture);
        internal static string FailedToFindToolAssembly => ResourceManager.GetString("FailedToFindToolAssembly", Culture);
        internal static string FailedToFindCommandPath => ResourceManager.GetString("FailedToFindCommandPath", Culture);
        internal static string UnableToLocateDotnetMultiplexer => ResourceManager.GetString("UnableToLocateDotnetMultiplexer", Culture);
        internal static string LookingForPreferCliRuntimeFile => ResourceManager.GetString("LookingForPreferCliRuntimeFile", Culture);
        internal static string IgnoringPreferCLIRuntimeFile => ResourceManager.GetString("IgnoringPreferCLIRuntimeFile", Culture);
        internal static string CouldNotFindToolRuntimeConfigFile => ResourceManager.GetString("CouldNotFindToolRuntimeConfigFile", Culture);
        internal static string AttemptingToResolve => ResourceManager.GetString("AttemptingToResolve", Culture);
        internal static string DidNotFindAMatchingProject => ResourceManager.GetString("DidNotFindAMatchingProject", Culture);
        internal static string InvalidCommandResolverArguments => ResourceManager.GetString("InvalidCommandResolverArguments", Culture);
        internal static string DoesNotExist => ResourceManager.GetString("DoesNotExist", Culture);
        internal static string AmbiguousCommandName => ResourceManager.GetString("AmbiguousCommandName", Culture);
        internal static string ToolLibraryFound => ResourceManager.GetString("ToolLibraryFound", Culture);
        internal static string MSBuildExePath => ResourceManager.GetString("MSBuildExePath", Culture);
        internal static string MSBuildProjectPath => ResourceManager.GetString("MSBuildProjectPath", Culture);
        internal static string MultipleProjectFilesFound => ResourceManager.GetString("MultipleProjectFilesFound", Culture);
        internal static string DidNotFindProject => ResourceManager.GetString("DidNotFindProject", Culture);
        internal static string ResolvingCommandSpec => ResourceManager.GetString("ResolvingCommandSpec", Culture);
        internal static string FailedToResolveCommandSpec => ResourceManager.GetString("FailedToResolveCommandSpec", Culture);
        internal static string AttemptingToResolveCommandSpec => ResourceManager.GetString("AttemptingToResolveCommandSpec", Culture);
        internal static string NuGetPackagesRoot => ResourceManager.GetString("NuGetPackagesRoot", Culture);
        internal static string FoundToolLockFile => ResourceManager.GetString("FoundToolLockFile", Culture);
        internal static string LibraryNotFoundInLockFile => ResourceManager.GetString("LibraryNotFoundInLockFile", Culture);
        internal static string AttemptingToCreateCommandSpec => ResourceManager.GetString("AttemptingToCreateCommandSpec", Culture);
        internal static string CommandSpecIsNull => ResourceManager.GetString("CommandSpecIsNull", Culture);
        internal static string ExpectDepsJsonAt => ResourceManager.GetString("ExpectDepsJsonAt", Culture);
        internal static string GeneratingDepsJson => ResourceManager.GetString("GeneratingDepsJson", Culture);
        internal static string UnableToGenerateDepsJson => ResourceManager.GetString("UnableToGenerateDepsJson", Culture);
        internal static string DepsJsonGeneratorProjectNotSet => ResourceManager.GetString("DepsJsonGeneratorProjectNotSet", Culture);
        internal static string UnableToDeleteTemporaryDepsJson => ResourceManager.GetString("UnableToDeleteTemporaryDepsJson", Culture);
        internal static string VersionForPackageCouldNotBeResolved => ResourceManager.GetString("VersionForPackageCouldNotBeResolved", Culture);
        internal static string FileNotFound => ResourceManager.GetString("FileNotFound", Culture);
        internal static string ProjectNotRestoredOrRestoreFailed => ResourceManager.GetString("ProjectNotRestoredOrRestoreFailed", Culture);
        internal static string NoExecutableFoundMatchingCommand => ResourceManager.GetString("NoExecutableFoundMatchingCommand", Culture);
        internal static string CommandAssembliesNotFound => ResourceManager.GetString("CommandAssembliesNotFound", Culture);
        internal static string WaitingForDebuggerToAttach => ResourceManager.GetString("WaitingForDebuggerToAttach", Culture);
        internal static string ProcessId => ResourceManager.GetString("ProcessId", Culture);
        internal static string CouldNotAccessAssetsFile => ResourceManager.GetString("CouldNotAccessAssetsFile", Culture);
        internal static string DotNetCommandLineTools => ResourceManager.GetString("DotNetCommandLineTools", Culture);
        internal static string DotNetSdkInfoLabel => ResourceManager.GetString("DotNetSdkInfoLabel", Culture);
        internal static string DotNetRuntimeInfoLabel => ResourceManager.GetString("DotNetRuntimeInfoLabel", Culture);
        internal static string WriteLineForwarderSetPreviously => ResourceManager.GetString("WriteLineForwarderSetPreviously", Culture);
        internal static string AlreadyCapturingStream => ResourceManager.GetString("AlreadyCapturingStream", Culture);
        internal static string RunningFileNameArguments => ResourceManager.GetString("RunningFileNameArguments", Culture);
        internal static string ProcessExitedWithCode => ResourceManager.GetString("ProcessExitedWithCode", Culture);
        internal static string UnableToInvokeMemberNameAfterCommand => ResourceManager.GetString("UnableToInvokeMemberNameAfterCommand", Culture);
        internal static string MSBuildArgs => ResourceManager.GetString("MSBuildArgs", Culture);
        internal static string EmbedAppNameInHostAppHostHasBeenModified => ResourceManager.GetString("EmbedAppNameInHostAppHostHasBeenModified", Culture);
        internal static string EmbedAppNameInHostFileNameIsTooLong => ResourceManager.GetString("EmbedAppNameInHostFileNameIsTooLong", Culture);
        internal static string CannotFindCommandAvailableAsTool => ResourceManager.GetString("CannotFindCommandAvailableAsTool", Culture);
        internal static string DotnetCliHomeUsed => ResourceManager.GetString("DotnetCliHomeUsed", Culture);
    }
}
