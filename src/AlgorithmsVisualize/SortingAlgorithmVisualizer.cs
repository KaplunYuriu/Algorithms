using Arrays;
using Infrastructure;
using System.Diagnostics;

namespace AlgorithmsVisualize
{
    static class SortingAlgorithmVisualizer
    {
        public static void Visualize(SortAlgorithmType type, int elementsNumber)
        {
            Console.WriteLine($"Elements in array: {elementsNumber}");

            foreach(SortAlgorithmType sortingType in type.GetFlags()) {
                Console.WriteLine($"Selected algorithm: {sortingType}");

                var algorithm = SortingAlgorithmFactory.GetAlgorithm(sortingType);

                var stopwatch = Stopwatch.StartNew();

                var sortedArray = algorithm.Sort(
                    ArrayGenerator.GenerateRandomArray(elementsNumber)
                );

                stopwatch.Stop();

                Console.WriteLine($"TimeElapsed: {stopwatch.Elapsed}");
            }
        }
    }
}
