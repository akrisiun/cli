﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using TestLibrary;

namespace TestApp
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("This string came from ProjectA");
            Console.WriteLine($"{ProjectD.GetMessage()}");
            return 0;
        }
    }
}
