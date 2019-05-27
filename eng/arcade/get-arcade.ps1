invoke-webrequest "http://black/nuget/nuget/FindPackagesById()?id='Microsoft.DotNet.Arcade.Sdk'&semVerLevel=2.0.0" `
  | select Content | fl

nuget install Microsoft.DotNet.Arcade.Sdk -version 1.0.0-dev
# 1.0.0-dev.nupkg