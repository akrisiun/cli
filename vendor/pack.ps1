
dotnet pack msbuild\src\Framework\Microsoft.Build.Framework.csproj   -o $PWD --include-source
dotnet pack msbuild\src\MSBuild\MSBuild.csproj                       -o $PWD --include-source
dotnet pack msbuild\src\Build\Microsoft.Build.csproj                 -o $PWD --include-source
dotnet pack msbuild\src\Utilities\Microsoft.Build.Utilities.csproj   -o $PWD --include-source
dotnet pack msbuild\src\Tasks\Microsoft.Build.Tasks.csproj           -o $PWD --include-source