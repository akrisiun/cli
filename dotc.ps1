# dotb + args

$ErrorActionPreference = 'Stop'
$a_args = $PsBoundParameters.Values + $args

write-host -f magenta "c:/bin/dotc/dotnet.exe $a_args | $args"

c:/bin/dotc/dotnet.exe $a_args