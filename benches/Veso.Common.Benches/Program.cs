﻿using System;
using BenchmarkDotNet.Running;

namespace Veso.Common.Benches
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<HexEncodeBenches>();
            _ = BenchmarkRunner.Run<HexDecodeBenches>();
        }
    }
}
