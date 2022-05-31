using Arrays.Algorithms.Structures;
using Infrastructure;
using Xunit;
using Xunit.Abstractions;

namespace ArrayTests.Structures
{
    public class TreeTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public TreeTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Tree_Heapify_CreatesHeap()
        {
            const int ElementsNumber = 100;

            var array = ArrayGenerator.GenerateRandomArray(ElementsNumber);

            var tree = MinTree.Heapify(array);

            Assert.NotNull(tree);

            _testOutputHelper.WriteLine(tree.ToString());
        }

        [Fact]
        public void Tree_ExtractMax_UntilEmpty()
        {
            const int ElementsNumber = 100_000;

            var array = ArrayGenerator.GenerateRandomArray(ElementsNumber);

            var tree = MinTree.Heapify(array);

            int i = 0;
            int previousMinValue = int.MinValue;
            while(tree.Capacity > 0)
            {
                int maxValue = tree.ExtractMax();

                _testOutputHelper.WriteLine("Max value: {0}, Iteration: {1}, Capacity: {2}", maxValue, ++i, tree.Capacity);

                Assert.True(previousMinValue <= maxValue, $"Expected to be greater than {previousMinValue}, Received {maxValue}");
                previousMinValue = maxValue;
            }
        }
    }
}
