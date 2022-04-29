namespace Arrays.Algorithms
{
    internal class Merge : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray) => SortImplementation(new Span<int>(unsortedArray));

        private int[] SortImplementation(Span<int> array)
        {
            if (array.Length <= 1)
                return array.ToArray();

            int divizion = array.Length / 2;

            var firstHalf = array[..divizion];
            var secondHalf = array[divizion..];

            return MergeArrays(SortImplementation(firstHalf), SortImplementation(secondHalf));
        }

        private int[] MergeArrays(int[] first, int[] second)
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
