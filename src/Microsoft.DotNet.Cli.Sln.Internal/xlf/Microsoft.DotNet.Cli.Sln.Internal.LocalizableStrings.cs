using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Cli.Sln.Internal
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.Sln.Internal.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string ErrorMessageFormatString => ResourceManager.GetString("ErrorMessageFormatString", Culture);
        internal static string ProjectParsingErrorFormatString => ResourceManager.GetString("ProjectParsingErrorFormatString", Culture);
        internal static string InvalidPropertySetFormatString => ResourceManager.GetString("InvalidPropertySetFormatString", Culture);
        internal static string GlobalSectionMoreThanOnceError => ResourceManager.GetString("GlobalSectionMoreThanOnceError", Culture);
        internal static string GlobalSectionNotClosedError => ResourceManager.GetString("GlobalSectionNotClosedError", Culture);
        internal static string FileHeaderMissingVersionError => ResourceManager.GetString("FileHeaderMissingVersionError", Culture);
        internal static string FileHeaderMissingError => ResourceManager.GetString("FileHeaderMissingError", Culture);
        internal static string ProjectSectionNotClosedError => ResourceManager.GetString("ProjectSectionNotClosedError", Culture);
        internal static string InvalidSectionTypeError => ResourceManager.GetString("InvalidSectionTypeError", Culture);
        internal static string SectionIdMissingError => ResourceManager.GetString("SectionIdMissingError", Culture);
        internal static string ClosingSectionTagNotFoundError => ResourceManager.GetString("ClosingSectionTagNotFoundError", Culture);
    }
}
