namespace Infrastructure
{
    public static class ArrayGenerator
    {
        public static int[] GenerateRandomArray(int elementsNumber)
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
