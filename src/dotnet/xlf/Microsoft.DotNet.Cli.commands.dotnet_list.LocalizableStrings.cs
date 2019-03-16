using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.List // .dotnet_list
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_list.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string NetListCommand => ResourceManager.GetString("NetListCommand", Culture);
    }
}
