using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools // .Cli.commands.dotnet_add
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_add.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string NetAddCommand => ResourceManager.GetString("NetAddCommand", Culture);
    }
}
