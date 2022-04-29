using ArrayTests.Benchmarks.Implementations;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests.Benchmarks
{

    public class ArraySortingAlgorithmBenchmarks
    {
        [Theory]
        [MemberData(nameof(Benchmarks))]
        public void Benchmark(ISortingAlgorithmBenchmark benchmark)
        {
            BenchmarkRunner.Run(benchmark.GetType());
        }

        public static IEnumerable<object[]> Benchmarks => new List<object[]>
        {
            new object[] { new InsertBenchmark() },
            new object[] { new MergeBenchmark() },
            new object[] { new BubbleBenchmark() },
            new object[] { new DefaultBenchmark() },
        };
    }
}
