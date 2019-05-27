// Copyright (c) .NET Foundation and contributors. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 
 
using System;  
using System.Linq; 
using Newtonsoft.Json.Linq; 
 
namespace Microsoft.DotNet.Cli.Utils.Old
{ 
    internal class RuntimeConfigFramework
    { 
        public string Name { get; set; } 
        public string Version { get; set; } 
 
        public static RuntimeConfigFramework ParseFromFrameworkRoot(JObject framework) 
        { 
            var properties = framework.Properties(); 
 
            var name = properties.FirstOrDefault(p => p.Name.Equals("name", StringComparison.OrdinalIgnoreCase)); 
            var version = properties.FirstOrDefault(p => p.Name.Equals("version", StringComparison.OrdinalIgnoreCase)); 
 
            if (name == null || version == null) 
            { 
                return null; 
            } 
 
            return new RuntimeConfigFramework 
            { 
                Name = name.Value.ToString(), 
                Version = version.Value.ToString() 
            }; 
        } 
    } 
}