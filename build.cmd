@REM @echo off

REM Copyright (c) .NET Foundation and contributors. All rights reserved.
REM Licensed under the MIT license. See LICENSE file in the project root for full license information.

@REM # powershell -ExecutionPolicy Bypass -NoProfile -NoLogo -Command "& \"%~dp0run-build.ps1\" %*; exit $LastExitCode;"
@REM # if %errorlevel% neq 0 exit /b %errorlevel%


.dotnet/dotnet msbuild build.proj /v:n
