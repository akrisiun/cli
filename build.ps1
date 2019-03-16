
# "& \"%~dp0run-build.ps1\" %*; exit $LastExitCode;"
# .\run-build.ps1 -InitTools

Write-Host "OS: " $PSVersionTable.Platform - $PSVersionTable.OS

if ($PSVersionTable.Platform -eq "Unix") {
   # todo DARWIN
   cp bin/osx/* bin/obj
   ls bin/obj
}

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:restore
.dotnet/dotnet msbuild build.proj /v:d /t:restore

# 2.1.403
# "sdk": {
#        "version": "3.0.100-preview3-010431"

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:build
# @REM .dotnet/dotnet msbuild build.proj /v:d /p:Architecture=x64 /p:GeneratePropsFile=true /t:WriteDynamicPropsToStaticPropsFiles

.dotnet/dotnet msbuild build.proj /v:n /t:BuildDotnetCliBuildFramework
.dotnet/dotnet msbuild build.proj /v:n /t:RestoreToolsPackages
.dotnet/dotnet restore src/redist

.dotnet/dotnet restore build/sdks
.dotnet/dotnet restore build/templates

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:build
.dotnet/dotnet msbuild src/redist/redist.csproj /v:m /t:publish

# fails Download:
# build\Prepare.targets
# build\compile\LzmaArchive.targets
# nuget install microsoft.dotnet.common.itemtemplates -version 1.0.2-beta3 -o .nuget/packages
# NU5000: Package 'Microsoft.DotNet.Common.ItemTemplates 1.0.2-beta3' has a package type 'Template' that is not supported by project :-(
# nuget install microsoft.dotnet.common.projecttemplates -o .nuget/packages

# .dotnet/dotnet msbuild build.proj /v:n