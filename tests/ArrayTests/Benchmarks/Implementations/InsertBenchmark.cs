using Arrays.Algorithms;
using BenchmarkDotNet.Attributes;

namespace ArrayTests.Benchmarks.Implementations
{
    [MemoryDiagnoser]
    public class InsertBenchmark : SortingAlgorithmBenchmarkBase, ISortingAlgorithmBenchmark
    {
        [Benchmark]
        public int[] Sort()
        {
            return new Insert().Sort(Array);
        }
    }
}
