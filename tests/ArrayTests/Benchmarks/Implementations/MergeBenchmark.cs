using Arrays.Algorithms;
using BenchmarkDotNet.Attributes;

namespace ArrayTests.Benchmarks.Implementations
{
    [MemoryDiagnoser]
    public class MergeBenchmark : SortingAlgorithmBenchmarkBase, ISortingAlgorithmBenchmark
    {
        [Benchmark]
        public int[] Sort()
        {
            return new Merge().Sort(Array);
        }
    }
}
