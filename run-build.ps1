#
# Copyright (c) .NET Foundation and contributors. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for full license information.
#

param(
    [string]$Configuration="Debug",
    [string]$Architecture="x64",
    [Parameter(ValueFromRemainingArguments=$true)][String[]]$ExtraParameters
)

$env:CONFIGURATION = $Configuration;
$RepoRoot = "$PSScriptRoot"
if(!$env:NUGET_PACKAGES){
  $env:NUGET_PACKAGES = "$RepoRoot\.nuget\packages"
}

$InstallArchitecture = $Architecture
if($Architecture.StartsWith("arm", [StringComparison]::OrdinalIgnoreCase))
{
    $InstallArchitecture = "x64"
}

$ArchitectureParam="/p:Architecture=$Architecture"
$ConfigurationParam="-configuration $Configuration"

write-host "$RepoRoot\eng\common\build.ps1 -restore -build $ConfigurationParam $ArchitectureParam $ExtraParameters"
Invoke-Expression "$RepoRoot\eng\common\build.ps1 -restore -build $ConfigurationParam $ArchitectureParam $ExtraParameters"

if ($NoBuild)
{
    Write-Output "Not building due to --nobuild"
    Write-Output "Command that would be run: 'dotnet msbuild build.proj /m /p:Architecture=$Architecture $ExtraParameters'"
}
else
{
    # .dotnet/dotnet msbuild build.proj /p:Architecture=x64 /p:GeneratePropsFile=true /t:WriteDynamicPropsToStaticPropsFiles
	# invoke-webrequest https://dotnetcli.azureedge.net/dotnet/aspnetcore/Runtime/2.1.9/aspnetcore_base_runtime.version |select Content |fl
    dotnet msbuild build.proj /bl:msbuild.generatepropsfile.binlog /p:Architecture=$Architecture /p:GeneratePropsFile=true /t:WriteDynamicPropsToStaticPropsFiles $ExtraParametersNoTargets
    dotnet msbuild build.proj /bl:msbuild.mainbuild.binlog /m /v:normal /fl /flp:v=diag /p:Architecture=$Architecture $ExtraParameters
    if($LASTEXITCODE -ne 0) { throw "Failed to build" } 
}
