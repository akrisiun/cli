# dotb + args

$ErrorActionPreference = 'Stop'
$a_args = $PsBoundParameters.Values + $args

# cd ~ / # mklink /D bin c:\bin
write-host -f magenta "~/bin/dotc/dotnet.exe $a_args | $args"

~/bin/dotc/dotnet.exe $a_args