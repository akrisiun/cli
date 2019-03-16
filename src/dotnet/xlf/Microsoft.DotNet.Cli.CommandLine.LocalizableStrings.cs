using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Cli.CommandLine // Microsoft.DotNet.Tools.CommandLine
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.CommandLine.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string LastArgumentMultiValueError => ResourceManager.GetString("LastArgumentMultiValueError", Culture);
        internal static string OptionRequiresSingleValueWhichIsMissing => ResourceManager.GetString("OptionRequiresSingleValueWhichIsMissing", Culture);
        internal static string UnexpectedValueForOptionError => ResourceManager.GetString("UnexpectedValueForOptionError", Culture);
        internal static string UnexpectedArgumentError => ResourceManager.GetString("UnexpectedArgumentError", Culture);
        internal static string ResponseFileNotFoundError => ResourceManager.GetString("ResponseFileNotFoundError", Culture);
        internal static string ShowHelpInfo => ResourceManager.GetString("ShowHelpInfo", Culture);
        internal static string ShowVersionInfo => ResourceManager.GetString("ShowVersionInfo", Culture);
        internal static string ShowHintInfo => ResourceManager.GetString("ShowHintInfo", Culture);
        internal static string UsageHeader => ResourceManager.GetString("UsageHeader", Culture);
        internal static string UsageArgumentsToken => ResourceManager.GetString("UsageArgumentsToken", Culture);
        internal static string UsageArgumentsHeader => ResourceManager.GetString("UsageArgumentsHeader", Culture);
        internal static string UsageOptionsToken => ResourceManager.GetString("UsageOptionsToken", Culture);
        internal static string UsageOptionsHeader => ResourceManager.GetString("UsageOptionsHeader", Culture);
        internal static string UsageCommandToken => ResourceManager.GetString("UsageCommandToken", Culture);
        internal static string UsageCommandsHeader => ResourceManager.GetString("UsageCommandsHeader", Culture);
        internal static string UsageCommandsDetailHelp => ResourceManager.GetString("UsageCommandsDetailHelp", Culture);
        internal static string UsageCommandArgs => ResourceManager.GetString("UsageCommandArgs", Culture);
        internal static string UsageCommandAdditionalArgs => ResourceManager.GetString("UsageCommandAdditionalArgs", Culture);
        internal static string UsageCommandsAdditionalArgsHeader => ResourceManager.GetString("UsageCommandsAdditionalArgsHeader", Culture);
        internal static string InvalidTemplateError => ResourceManager.GetString("InvalidTemplateError", Culture);
        internal static string MSBuildAdditionalArgsHelpText => ResourceManager.GetString("MSBuildAdditionalArgsHelpText", Culture);
        internal static string CommandAcceptsOnlyOneArgument => ResourceManager.GetString("CommandAcceptsOnlyOneArgument", Culture);
        internal static string CommandAcceptsOnlyOneSubcommand => ResourceManager.GetString("CommandAcceptsOnlyOneSubcommand", Culture);
        internal static string FileDoesNotExist => ResourceManager.GetString("FileDoesNotExist", Culture);
        internal static string NoArgumentsAllowed => ResourceManager.GetString("NoArgumentsAllowed", Culture);
        internal static string OptionAcceptsOnlyOneArgument => ResourceManager.GetString("OptionAcceptsOnlyOneArgument", Culture);
        internal static string RequiredArgumentMissingForCommand => ResourceManager.GetString("RequiredArgumentMissingForCommand", Culture);
        internal static string RequiredArgumentMissingForOption => ResourceManager.GetString("RequiredArgumentMissingForOption", Culture);
        internal static string RequiredCommandWasNotProvided => ResourceManager.GetString("RequiredCommandWasNotProvided", Culture);
        internal static string UnrecognizedArgument => ResourceManager.GetString("UnrecognizedArgument", Culture);
        internal static string UnrecognizedCommandOrArgument => ResourceManager.GetString("UnrecognizedCommandOrArgument", Culture);
        internal static string UnrecognizedOption => ResourceManager.GetString("UnrecognizedOption", Culture);
    }
}
