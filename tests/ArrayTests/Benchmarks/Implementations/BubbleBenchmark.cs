using Arrays.Algorithms;
using BenchmarkDotNet.Attributes;

namespace ArrayTests.Benchmarks.Implementations
{
    [MemoryDiagnoser]
    public class BubbleBenchmark : SortingAlgorithmBenchmarkBase, ISortingAlgorithmBenchmark
    {
        [Benchmark]
        public int[] Sort()
        {
            return new Bubble().Sort(Array);
        }
    }
}
