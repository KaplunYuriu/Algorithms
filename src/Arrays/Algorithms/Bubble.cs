namespace Arrays.Algorithms
{
    internal class Bubble : ISortingAlgorithm
    {
        public int[] Sort(int[] unsortedArray)
        {
            do
            {
                bool anySwaps = false;
                for (int j = 0; j < unsortedArray.Length - 1; j++)
                {
                    int currElement = unsortedArray[j];
                    int nextElement = unsortedArray[j + 1];
                    if (currElement > nextElement)
                    {
                        anySwaps = true;
                        int temp = currElement;
                        unsortedArray[j] = nextElement;
                        unsortedArray[j + 1] = temp;
                    }
                }

                if (!anySwaps)
                    break;
            }
            while (true);

            return unsortedArray;
        }
    }
}
