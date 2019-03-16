using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Build // .dotnet_build.xlf.LocalizableStrings
{
    internal static class xlf
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_build.xlf.LocalizableStrings.xlf", typeof(xlf).GetTypeInfo().Assembly);
    }
}
