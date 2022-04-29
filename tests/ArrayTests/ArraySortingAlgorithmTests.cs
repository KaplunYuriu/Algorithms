using Arrays.Algorithms;
using Infrastructure;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class ArraySortingAlgorithmTests
    {
        const int ElementsNumber = 10_000;

        [Theory]
        [MemberData(nameof(SortingAlgorithms))]
        public void Sort_CorrectOrder(ISortingAlgorithm algorithm)
        {
            var array = ArrayGenerator.GenerateRandomArray(ElementsNumber);

            var sortedArray = algorithm.Sort(array);

            for (int i = 0; i < ElementsNumber - 1; i++)
            {
                Assert.True(sortedArray[i] <= sortedArray[i + 1], $"Elements incorrect: Index: {i}, Current Element: {sortedArray[i]}, Next Value: {sortedArray[i + 1]}");
            }
        }

        public static IEnumerable<object[]> SortingAlgorithms => new List<object[]>
        {
            new object[] { new Insert() },
            new object[] { new Merge() },
            new object[] { new Bubble() },
        };
    }
}