using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Add // .dotnet_add.xlf.LocalizableStrings
{
    internal static class Xlf
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_add.xlf.LocalizableStrings.xlf", typeof(Xlf).GetTypeInfo().Assembly);
    }
}
