using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Migrate // .dotnet_migrate
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_migrate.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CmdProjectArgument => ResourceManager.GetString("CmdProjectArgument", Culture);
        internal static string CmdProjectArgumentDescription => ResourceManager.GetString("CmdProjectArgumentDescription", Culture);
        internal static string CmdTemplateDescription => ResourceManager.GetString("CmdTemplateDescription", Culture);
        internal static string CmdVersionDescription => ResourceManager.GetString("CmdVersionDescription", Culture);
        internal static string CmdXprojFileDescription => ResourceManager.GetString("CmdXprojFileDescription", Culture);
        internal static string CmdSkipProjectReferencesDescription => ResourceManager.GetString("CmdSkipProjectReferencesDescription", Culture);
        internal static string CmdReportFileDescription => ResourceManager.GetString("CmdReportFileDescription", Culture);
        internal static string CmdReportOutputDescription => ResourceManager.GetString("CmdReportOutputDescription", Culture);
        internal static string CmdSkipBackupDescription => ResourceManager.GetString("CmdSkipBackupDescription", Culture);
        internal static string MigrationFailedError => ResourceManager.GetString("MigrationFailedError", Culture);
        internal static string MigrationAdditionalHelp => ResourceManager.GetString("MigrationAdditionalHelp", Culture);
        internal static string MigrationReportSummary => ResourceManager.GetString("MigrationReportSummary", Culture);
        internal static string MigrationReportTotalProjects => ResourceManager.GetString("MigrationReportTotalProjects", Culture);
        internal static string MigrationReportSucceededProjects => ResourceManager.GetString("MigrationReportSucceededProjects", Culture);
        internal static string MigrationReportFailedProjects => ResourceManager.GetString("MigrationReportFailedProjects", Culture);
        internal static string ProjectMigrationSucceeded => ResourceManager.GetString("ProjectMigrationSucceeded", Culture);
        internal static string ProjectMigrationFailed => ResourceManager.GetString("ProjectMigrationFailed", Culture);
        internal static string MigrationFailedToFindProjectInGlobalJson => ResourceManager.GetString("MigrationFailedToFindProjectInGlobalJson", Culture);
        internal static string MigrationUnableToFindProjects => ResourceManager.GetString("MigrationUnableToFindProjects", Culture);
        internal static string MigrationProjectJsonNotFound => ResourceManager.GetString("MigrationProjectJsonNotFound", Culture);
        internal static string MigrationInvalidProjectArgument => ResourceManager.GetString("MigrationInvalidProjectArgument", Culture);
        internal static string MigratonUnableToFindProjectJson => ResourceManager.GetString("MigratonUnableToFindProjectJson", Culture);
        internal static string MigrationUnableToFindGlobalJson => ResourceManager.GetString("MigrationUnableToFindGlobalJson", Culture);
        internal static string MigrationUnableToFindSolutionFile => ResourceManager.GetString("MigrationUnableToFindSolutionFile", Culture);
        internal static string MigrateFilesBackupLocation => ResourceManager.GetString("MigrateFilesBackupLocation", Culture);
    }
}
