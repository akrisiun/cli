# ./pack

dotc msbuild Arcade.Sdk /t:build
dotc pack Arcade.Sdk -o $PWD

dotc msbuild Tasks.Feed /t:build
dotc pack Tasks.Feed -o $PWD