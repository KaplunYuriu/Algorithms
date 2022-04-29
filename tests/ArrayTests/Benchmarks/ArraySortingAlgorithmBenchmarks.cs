using BenchmarkDotNet.Running;
using Xunit;

namespace ArrayTests.Benchmarks
{
    public class ArraySortingAlgorithmBenchmarks
    {
        [Fact]
        public void Benchmark()
        {
            BenchmarkRunner.Run<SortingAlgorithmsContainer>();
        }
    }
}
