using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Cli.CommandLine.xlf.LocalizableStrings
{
    internal static class _xlf
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = 
            new ResourceManager("Microsoft.DotNet.Cli.CommandLine.xlf.LocalizableStrings.xlf", 
            typeof(_xlf).GetTypeInfo().Assembly);
    }
}
