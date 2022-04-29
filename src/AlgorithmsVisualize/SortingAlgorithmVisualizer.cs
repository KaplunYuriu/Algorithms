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
                    PrepareArray(elementsNumber)
                );

                stopwatch.Stop();

                Console.WriteLine($"TimeElapsed: {stopwatch.Elapsed}");
            }
        }


        private static int[] PrepareArray(int elementsNumber)
        {
            var array = new int[elementsNumber];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(5_000);
            }

            return array;
        }
    }
}
