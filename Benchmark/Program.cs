using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static XMLhomework.XMLParse;

namespace Benchmark
{
    public class XMLParse
    {
        [Benchmark]
        public bool Benchmark() => Parse(@"/Users/martincerveny/RiderProjects/XMLhomework/XMLhomework/test.xml");
    }

    class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<XMLParse>();
        }
    }
}