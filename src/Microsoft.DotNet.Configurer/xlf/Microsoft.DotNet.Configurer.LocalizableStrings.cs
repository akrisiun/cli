using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Configurer
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Configurer.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string FirstTimeWelcomeMessage => ResourceManager.GetString("FirstTimeWelcomeMessage", Culture);
        internal static string NugetCachePrimeMessage => ResourceManager.GetString("NugetCachePrimeMessage", Culture);
        internal static string FailedToPrimeCacheError => ResourceManager.GetString("FailedToPrimeCacheError", Culture);
        internal static string UnauthorizedAccessMessage => ResourceManager.GetString("UnauthorizedAccessMessage", Culture);
        internal static string AspNetCertificateInstalled => ResourceManager.GetString("AspNetCertificateInstalled", Culture);
        internal static string FailedToDetermineUserHomeDirectory => ResourceManager.GetString("FailedToDetermineUserHomeDirectory", Culture);
    }
}
