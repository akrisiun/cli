
# ./sudo.ps1 
# bin\2\win-x64\bin\dotnet\Debug\netcoreapp2.2\

# .dotnet\dotnet.exe 
dotnet build src\dotnet\dotnet.csproj -o .\lib\ -c Debug

.\lib\dotnet.exe --info