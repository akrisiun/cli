
# ./sudo.ps1 

.dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o c:\bin\dotb\ -c Debug

$env:DOTNET_CLI_CAPTURE_TIMING=1
c:\bin\dotb\dotb.exe --debug --info