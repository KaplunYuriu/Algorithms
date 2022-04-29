namespace Arrays
{
    [Flags]
    public enum SortAlgorithmType
    {
        Default = 1,
        Bubble = 2,
        Merge = 4,
        Insert = 8,


        All = Default | Bubble | Merge | Insert,
    }
}
