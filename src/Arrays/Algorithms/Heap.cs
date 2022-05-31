using Arrays.Algorithms.Structures;

namespace Arrays.Algorithms
{
    internal class Heap : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            var maxTree = MinTree.Heapify(unsortedArray);

            int[] newArray = new int[unsortedArray.Length];

            int index = 0;
            while (maxTree.Capacity > 0)
            {
                newArray[index++] = maxTree.ExtractMax();
            }

            return newArray;
        }
    }
}
