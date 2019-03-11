
# ./sudo.ps1 
# bin\2\win-x64\bin\dotnet\Debug\netcoreapp2.2\

# .dotnet\dotnet.exe 
.dotnet\dotnet.exe build src\dotnet\dotnet.csproj -o .\lib\ -c Debug

.\lib\dotnet.exe --info

$env:DOTNET_CLI_CAPTURE_TIMING=1