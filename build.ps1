
$Configuration="Debug"
$ArchitectureParam="/p:Architecture=x64"
$ConfigurationParam="-configuration $Configuration"

# ./eng/common/build.ps1 -restore
# ./eng/common/build.ps1 -build $ConfigurationParam $ArchitectureParam

# .dotnet/dotnet build src/dotnet -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0

# ./eng/common/build.ps1 -build /p:Architecture=x64
$dotc = "c:\bin\dotc\dotnet.exe"

dotc restore build.proj -v n /p:GeneratePropsFile=true
dotc restore src/dotnet -f netcoreapp2.1

dotc restore build/RestoreDependency.proj
dotc restore build\sdks\sdks.csproj 
dotc restore src/redist

dotc restore build/BundledDotnetTools.proj
dotc restore build/BundledTemplates.projs
dotc build build_projects\shared-build-targets-utils
dotc build build_projects\dotnet-cli-build
dotc build build_projects\dotnet-cli-build			 -o build_projects\dotnet-cli-build\bin
dotc build build_projects\shared-build-targets-utils -o build_projects\dotnet-cli-build\bin

dotc msbuild build\RestoreDependency.proj /t:EnsureDependencyRestored

dotc build src/dotnet
dotc publish src/dotnet -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0  -f netcoreapp3.0
dotc publish src/Microsoft.DotNet.Configurer  -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0
dotc publish src/Microsoft.DotNet.InternalAbstractions  -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0
dotc publish src/Microsoft.DotNet.Cli.Utils  -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0 -f netcoreapp3.0
dotc publish src/Microsoft.DotNet.Cli.Sln.Internal -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0

# .dotnet/dotnet.exe msbuild src/dotnet/dotnet.csproj /t:build /v:d
dotc restore DotNet.Cli.sln
dotc build src/redist
dotc publish src/redist -f netcoreapp2.1

# dotc publish src/redist -o .\artifacts\bin\dotnet\Debug\netcoreapp3.0

# Success?
# 2.0.601-dev1
dotc .\bin\2\win-x64\dotnet\sdk\2.1.601-dev1-009587\dotnet.dll --info
