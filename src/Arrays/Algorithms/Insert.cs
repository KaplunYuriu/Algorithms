namespace Arrays.Algorithms
{
    internal class Insert : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                if (currentElement < array[i - 1])
                {
                    for (int j = i - 1; j >= 0 ; j--)
                    {
                        bool isGoodToInsert = currentElement <= array[j] &&
                            (j == 0 || currentElement > array[j - 1]);

                        if (isGoodToInsert)
                        {
                            Move(ref array, i, j);
                            array[j] = currentElement;
                            break;
                        }
                    }
                }
            }

            return array;
        }

        private void Move(ref int[] array, int startPosition, int endPosition)
        {
            for (int i = startPosition; i > endPosition; i--)
            {
                array[i] = array[i - 1];
            }
        }
    }
}
