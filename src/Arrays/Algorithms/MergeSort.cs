namespace Arrays.Algorithms
{
    internal class MergeSort : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray.Length <= 1)
                return unsortedArray;

            int divizion = unsortedArray.Length / 2;

            int[] firstHalf = unsortedArray[0..divizion];
            int[] secondHalf = unsortedArray[divizion..unsortedArray.Length];

            var mergedResult = Merge(Sort(firstHalf), Sort(secondHalf));

            return mergedResult.ToArray();
        }

        private int[] Merge(int[] first, int[] second)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int resultIndex = 0;

            var result = new int[first.Length + second.Length];
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (firstIndex < first.Length && secondIndex < second.Length)
                {
                    if (first[firstIndex] > second[secondIndex])
                    {
                        result[resultIndex++] = second[secondIndex++];
                    }
                    else
                    {
                        result[resultIndex++] = first[firstIndex++];
                    }
                }
                else if (firstIndex < first.Length)
                {
                    result[resultIndex++] = first[firstIndex++];
                }
                else if (secondIndex < second.Length)
                {
                    result[resultIndex++] = second[secondIndex++];
                }
            }
            return result;
        }
    }
}
