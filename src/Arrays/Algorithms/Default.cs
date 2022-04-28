namespace Arrays.Algorithms
{
    internal class Default : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            Array.Sort(unsortedArray);

            return unsortedArray;
        }
    }
}
