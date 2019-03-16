using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.Remove //.dotnet_remove
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_remove.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string NetRemoveCommand => ResourceManager.GetString("NetRemoveCommand", Culture);
    }
}
