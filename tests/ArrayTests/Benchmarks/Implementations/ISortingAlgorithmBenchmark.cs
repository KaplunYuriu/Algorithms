using BenchmarkDotNet.Attributes;

namespace ArrayTests.Benchmarks.Implementations
{
    public interface ISortingAlgorithmBenchmark
    {
        [Benchmark]
        int[] Sort();
    }
}
