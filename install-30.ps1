
Invoke-WebRequest 'https://dot.net/v1/dotnet-install.ps1'  -OutFile .dotnet/dotnet-install.ps1
.dotnet/dotnet-install.ps1 -InstallDir .dotnet -Version 3.0.100-preview4-010386

# link: https://dotnetcli.azureedge.net/dotnet/Sdk/2.2.104/dotnet-sdk-2.2.104-win-x64.zip