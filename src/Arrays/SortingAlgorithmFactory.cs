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
                case SortAlgorithmType.Bubble: return new Bubble();
                case SortAlgorithmType.MergeSort: return new Merge();
                default: throw new ArgumentException(nameof(type));
            }
        }
    }
}
