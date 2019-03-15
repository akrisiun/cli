
# "& \"%~dp0run-build.ps1\" %*; exit $LastExitCode;"
# .\run-build.ps1 -InitTools

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:restore
.dotnet/dotnet msbuild build.proj /v:d /t:restore

# nuget install microsoft.dotnet.build.tasks.feed -Version 3.0.0-preview1-03623-01 -o packages

# 2.1.403
.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:build
# @REM .dotnet/dotnet msbuild build.proj /v:d /p:Architecture=x64 /p:GeneratePropsFile=true /t:WriteDynamicPropsToStaticPropsFiles

.dotnet/dotnet msbuild build.proj /v:n /t:BuildDotnetCliBuildFramework
.dotnet/dotnet msbuild build.proj /v:n /t:RestoreToolsPackages
.dotnet/dotnet restore src/redist

.dotnet/dotnet restore build/sdks
.dotnet/dotnet restore build/templates

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:build
.dotnet/dotnet msbuild src/redist/redist.proj /v:m /t:publish
# .dotnet/dotnet msbuild build.proj /v:n