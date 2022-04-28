using Arrays;
using System.Diagnostics;

namespace AlgorithmsVisualize
{
    static class SortingAlgorithmVisualizer
    {
        public static void Visualize()
        {
            const int ElementsNumber = 100_000_000;

            var array = PrepareArray(ElementsNumber);
            Console.WriteLine($"Elements in array: {ElementsNumber}");

            foreach(SortAlgorithmType sortingType in Enum.GetValues(typeof(SortAlgorithmType))) {
                Console.WriteLine($"Selected algorithm: {sortingType}");

                var algorithm = SortingAlgorithmFactory.GetAlgorithm(sortingType);

                var stopwatch = Stopwatch.StartNew();

                var sortedArray = algorithm.Sort(array);

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
