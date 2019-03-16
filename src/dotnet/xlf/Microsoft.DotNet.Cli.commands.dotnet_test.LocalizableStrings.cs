using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Test // .Cli.commands.dotnet_test
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_test.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string AppFullName => ResourceManager.GetString("AppFullName", Culture);
        internal static string AppDescription => ResourceManager.GetString("AppDescription", Culture);
        internal static string CmdSettingsFile => ResourceManager.GetString("CmdSettingsFile", Culture);
        internal static string CmdSettingsDescription => ResourceManager.GetString("CmdSettingsDescription", Culture);
        internal static string CmdListTestsDescription => ResourceManager.GetString("CmdListTestsDescription", Culture);
        internal static string CmdTestCaseFilterExpression => ResourceManager.GetString("CmdTestCaseFilterExpression", Culture);
        internal static string CmdTestCaseFilterDescription => ResourceManager.GetString("CmdTestCaseFilterDescription", Culture);
        internal static string CmdTestAdapterPathDescription => ResourceManager.GetString("CmdTestAdapterPathDescription", Culture);
        internal static string CmdTestAdapterPath => ResourceManager.GetString("CmdTestAdapterPath", Culture);
        internal static string CmdLoggerOption => ResourceManager.GetString("CmdLoggerOption", Culture);
        internal static string CmdLoggerDescription => ResourceManager.GetString("CmdLoggerDescription", Culture);
        internal static string CmdOutputDir => ResourceManager.GetString("CmdOutputDir", Culture);
        internal static string CmdOutputDescription => ResourceManager.GetString("CmdOutputDescription", Culture);
        internal static string CmdPathToLogFile => ResourceManager.GetString("CmdPathToLogFile", Culture);
        internal static string CmdPathTologFileDescription => ResourceManager.GetString("CmdPathTologFileDescription", Culture);
        internal static string CmdNoBuildDescription => ResourceManager.GetString("CmdNoBuildDescription", Culture);
        internal static string CmdResultsDirectoryDescription => ResourceManager.GetString("CmdResultsDirectoryDescription", Culture);
        internal static string CmdPathToResultsDirectory => ResourceManager.GetString("CmdPathToResultsDirectory", Culture);
        internal static string RunSettingsArgumentsDescription => ResourceManager.GetString("RunSettingsArgumentsDescription", Culture);
        
        internal static string cmdCollectFriendlyName => ResourceManager.GetString("cmdCollectFriendlyName", Culture);
        internal static string cmdCollectDescription => ResourceManager.GetString("cmdCollectDescription", Culture);
        internal static string CmdBlameDescription => ResourceManager.GetString("CmdBlameDescription", Culture);
        internal static string FrameworkOptionDescription => ResourceManager.GetString("FrameworkOptionDescription", Culture);
        internal static string ConfigurationOptionDescription => ResourceManager.GetString("ConfigurationOptionDescription", Culture);
    }
}
