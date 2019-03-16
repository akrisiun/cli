using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.DotNet.Tools.BuildServer // Cli.commands.dotnet_buildserver
{
    internal static class LocalizableStrings
    {
        internal static CultureInfo Culture { get; set; }
        internal static ResourceManager ResourceManager { get; } = new ResourceManager("Microsoft.DotNet.Cli.commands.dotnet_buildserver.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
        internal static string BuildServerCommandName => ResourceManager.GetString("BuildServerCommandName", Culture);
        internal static string CommandDescription => ResourceManager.GetString("CommandDescription", Culture);
    }
}
