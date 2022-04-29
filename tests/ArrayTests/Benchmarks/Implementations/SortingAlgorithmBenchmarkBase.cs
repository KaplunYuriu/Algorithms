using Infrastructure;
using System;

namespace ArrayTests.Benchmarks.Implementations
{
    public class SortingAlgorithmBenchmarkBase
    {
        private const int ElementsNumber = 100_000_000;

        protected readonly int[] Array;

        protected SortingAlgorithmBenchmarkBase()
        {
            Array = ArrayGenerator.GenerateRandomArray(ElementsNumber);
        }
    }
}
