using Arrays.Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Infrastructure;

namespace ArrayTests.Benchmarks
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.ColdStart, launchCount: 1)]
    public class SortingAlgorithmsContainer
    {
        private const int ElementsNumber = 1_000_000_000;

        [Benchmark]
        public void Bubble()
        {
            new Bubble().Sort(ArrayGenerator.GenerateRandomArray(ElementsNumber));
        }

        [Benchmark]
        public void Insert()
        {
            new Insert().Sort(ArrayGenerator.GenerateRandomArray(ElementsNumber));
        }

        [Benchmark]
        public void Merge()
        {
            new Merge().Sort(ArrayGenerator.GenerateRandomArray(ElementsNumber));
        }

        public void Heap()
        {
            new Heap().Sort(ArrayGenerator.GenerateRandomArray(ElementsNumber));
        }

        [Benchmark]
        public void Default()
        {
            new Default().Sort(ArrayGenerator.GenerateRandomArray(ElementsNumber));
        }
    }
}
