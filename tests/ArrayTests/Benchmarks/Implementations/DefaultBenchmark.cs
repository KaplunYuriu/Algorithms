using Arrays.Algorithms;
using BenchmarkDotNet.Attributes;

namespace ArrayTests.Benchmarks.Implementations
{
    [MemoryDiagnoser]
    public class DefaultBenchmark : SortingAlgorithmBenchmarkBase, ISortingAlgorithmBenchmark
    {
        [Benchmark]
        public int[] Sort()
        {
            return new Default().Sort(Array);
        }
    }
}
