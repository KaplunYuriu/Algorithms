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
                case SortAlgorithmType.Merge: return new Merge();
                case SortAlgorithmType.Insert: return new Insert();
                case SortAlgorithmType.Heap: return new Heap();
                default: throw new ArgumentException(nameof(type));
            }
        }
    }
}
