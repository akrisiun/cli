param([string]$a, [string] $a2, [string] $a3, [string] $a4)

dotnet build --no-restore /p:GenerateFullPaths=true $a $a2 $a3
