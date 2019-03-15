@REM @echo off

REM Copyright (c) .NET Foundation and contributors. All rights reserved.
REM Licensed under the MIT license. See LICENSE file in the project root for full license information.

@REM # powershell -ExecutionPolicy Bypass -NoProfile -NoLogo -Command "& \"%~dp0run-build.ps1\" %*; exit $LastExitCode;"
@REM # if %errorlevel% neq 0 exit /b %errorlevel%

@REM .\run-build.ps1 -InitTools

cd .dotnet/
.\dotnet-install.ps1 -version 2.1.500 --install-dir .
cd ..

.dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:restore
.dotnet/dotnet msbuild build.proj /v:d /t:restore
@REM .dotnet/dotnet msbuild build.proj /v:d /p:Architecture=x64 /p:GeneratePropsFile=true /t:WriteDynamicPropsToStaticPropsFiles
@REM # 2.1.403
@REM .dotnet/dotnet msbuild build_projects/dotnet-cli-build/dotnet-cli-build.csproj  /t:build

.dotnet/dotnet msbuild build.proj /v:n
