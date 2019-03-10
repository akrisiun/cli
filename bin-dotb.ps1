
# ./sudo.ps1 
$ErrorActionPreference = 'Stop'
$a_args = $PsBoundParameters.Values + $args

if (-not (test-path c:\bin\dotb\dotnet.dll)) {
  write-host ".dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o c:\bin\dotb\ -c Debug"
  .dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o c:\bin\dotb\ -c Debug
}

$env:DOTNET_CLI_CAPTURE_TIMING=1
$env:MSBUILD_EXE_PATH="c:\bin\dotb\sdk\3.0.100-preview4-010386\MSBuild.dll"
$env:MSBUILDEXTENSIONSPATH="c:\bin\dotb\sdk\3.0.100-preview4-010386"
$env:COREHOST_TRACE=1
if (test-path c:\bin\dotb\MSBuild.dll) {
    $env:MSBUILD_EXE_PATH="c:\bin\dotb\MSBuild.dll"
    # Build.CommandLine ProcessCommandLineSwitches
}
write-host -f magenta "c:\bin\dotb\dotb.exe --debug $a_args | MSBUILD_EXE_PATH=$env:MSBUILD_EXE_PATH"

$count = 1
# write-host $args.Count

if ($count -gt 0) {
  c:\bin\dotb\dotb.exe --debug $a_args
} else {  
  c:\bin\dotb\dotb.exe --debug --info
}
