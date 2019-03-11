
# ./sudo.ps1 
$ErrorActionPreference = 'Stop'
$a_args = $PsBoundParameters.Values + $args

if (-not (test-path c:\bin\dotb\dotnet.dll)) {
  write-host ".dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o c:\bin\dotb\ -c Debug"
  
  .dotnet\dotnet.exe build vendor\msbuild\src\MSBuild\MSBuild.csproj -o c:\bin\dotb\ -c Debug -f netcoreapp3.0
  .dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o c:\bin\dotb\ -c Debug
}

$env:DOTNET_CLI_CAPTURE_TIMING=1
$env:MSBUILD_EXE_PATH="c:\bin\dotb\sdk\3.0.100-preview4-010386\MSBuild.dll"
$env:MSBUILDEXTENSIONSPATH="c:\bin\dotb\sdk\3.0.100-preview4-010386"

$env:MSBUILD_EXE_PATH="c:\Program Files\dotnet\3.0.100-preview4-010386\MSBuild.dll"
$env:MSBUILDEXTENSIONSPATH="c:\Program Files\dotnet\3.0.100-preview4-010386"
$env:MSBuildSDKsPath="c:\Program Files\dotnet\sdk\2.2.104\Sdks"

$env:COREHOST_TRACE=0
$env:DOTNET_CLI_CONTEXT_VERBOSE=1
$env:MSBUILDDEBUGONSTART=1
$env:DOTNET_HOST_PATH="c:\bin\dotb\dotb.exe"

if (test-path c:\bin\dotb\MSBuild.dll) {
    $env:MSBUILD_EXE_PATH="c:\bin\dotb\MSBuild.dll"
    # Build.CommandLine ProcessCommandLineSwitches
}

write-host -f magenta "c:\bin\dotb\dotb.exe --debug $a_args | MSBUILD_EXE_PATH=$env:MSBUILD_EXE_PATH"

$count = $args.Count
write-host $args.Count

if ($count -gt 0) {
  $env:COREHOST_TRACE=1
  c:\bin\dotb\dotb.exe --debug $a_args
} else {  
  c:\bin\dotb\dotb.exe --info
}
