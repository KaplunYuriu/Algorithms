using Arrays.Algorithms;
using System;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class ArraySortingAlgorithmTests
    {
        const int ElementsNumber = 1000;

        [Theory]
        [MemberData(nameof(SortingAlgorithms))]
        public void Sort_CorrectOrder(ISortingAlgorithm algorithm)
        {
            var array = PrepareArray();

            var sortedArray = algorithm.Sort(array);

            for (int i = 0; i < ElementsNumber - 1; i++)
            {
                Assert.True(sortedArray[i] <= sortedArray[i + 1], $"Elements incorrect: Index: {i}, Current Element: {sortedArray[i]}, Next Value: {sortedArray[i]}");
            }
        }

        public static IEnumerable<object[]> SortingAlgorithms => new List<object[]>
        {
            new object[] { new Merge() },
            new object[] { new Bubble() },
        };

        private int[] PrepareArray()
        {
            var array = new int[ElementsNumber];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(5_000);
            }

            return array;
        }
    }
}