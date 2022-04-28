using Arrays.Algorithms;

namespace Arrays
{
    public static class SortingAlgorithmFactory
    {
        public static ISortingAlgorithm GetAlgorithm(SortAlgorithmType type)
        {
            switch (type)
            {
                case SortAlgorithmType.Default: return new Default();
                case SortAlgorithmType.MergeSort: return new MergeSort();
                default: throw new ArgumentException(nameof(type));
            }
        }
    }
}
