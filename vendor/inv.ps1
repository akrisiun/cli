invoke-webrequest "http://localhost/nuget/nuget/FindPackagesById()?id='Microsoft.Build.Framework'&semVerLevel=2.0.0" `
	 | select Content |fl

invoke-webrequest "http://localhost/nuget/nuget/FindPackagesById()?id='Microsoft.Build'&semVerLevel=2.0.0" `
	 | select Content |fl
