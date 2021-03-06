using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools // Cli.xlf.CommonLocalizableStrings
{
    internal static class xlf
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.xlf.CommonLocalizableStrings.xlf", typeof(xlf).GetTypeInfo().Assembly);
    }
}
