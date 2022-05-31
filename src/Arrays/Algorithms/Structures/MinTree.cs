using System.Text;

namespace Arrays.Algorithms.Structures
{
    internal class MinTree
    {
        private readonly int[] _heap;

        public int Capacity { get; private set; }

        private int _currentSize = 0;


        private MinTree(int capacity)
        {
            Capacity = capacity;
            _heap = new int[capacity];
        }

        public static MinTree Heapify(int[] array)
        {
            var tree = new MinTree(array.Length);

            foreach (var item in array)
            {
                tree.Insert(item);
            }

            return tree;
        }

        public int Parent(int i) => (i - 1) / 2;
        public int LeftChild(int i) => 2 * i + 1;
        public int RightChild(int i) => 2 * i + 2;

        public int GetMin() => _heap[0];
        public int ExtractMax()
        {
            const int MaxElementIndex = 0;

            int max = _heap[MaxElementIndex];

            _heap[MaxElementIndex] = int.MaxValue;

            Heapify();

            Capacity--;
            _currentSize--;

            return max;
        }

        public int DecreaseKey(int key) => 1;

        public void Insert(int item)
        {
            if (_currentSize == Capacity)
                return;

            int i = _currentSize;
            _heap[i] = item;
            _currentSize++;

            while (i != 0 && _heap[i] < _heap[Parent(i)])
            {
                Swap(ref _heap[i], ref _heap[Parent(i)]);

                i = Parent(i);
            }
        }

        private void Heapify(int i = 0)
        {
            if (i >= _heap.Length)
                return;

            int element = _heap[i];

            int ri = RightChild(i);
            int li = LeftChild(i);

            int rc = ri < _heap.Length ? _heap[ri] : int.MinValue;
            int lc = li < _heap.Length ? _heap[li] : int.MinValue;

            if (rc < element || lc < element)
            {
                if (rc < lc)
                {
                    if (ri < _heap.Length)
                    {
                        Swap(ref _heap[i], ref _heap[ri]);

                        Heapify(ri);
                    }
                }
                else
                {
                    if (li < _heap.Length)
                    {
                        Swap(ref _heap[i], ref _heap[li]);

                        Heapify(li);
                    }
                }
            }
        }

        public void Swap(ref int i, ref int j)
        {
            int temp = j;
            j = i;
            i = temp;
        }


        public override string ToString()
        {
            var builder = new StringBuilder();

            Display(builder, 1, 0);

            return builder.ToString();
        }

        public void Display(StringBuilder builder, int level, int currentIndex)
        {
            if (currentIndex >= _heap.Length)
                return;

            for (int i = 0; i < level; i++)
                builder.Append('-');

            builder.AppendLine($"({_heap[currentIndex]})");

            int leftChildIndex = LeftChild(currentIndex);

            if (leftChildIndex < _heap.Length)
            {
                Display(builder, level + 1, leftChildIndex);
            }

            int rightChildIndex = RightChild(currentIndex);

            if (rightChildIndex < _heap.Length)
            {
                Display(builder, level + 1, rightChildIndex);
            }
        }
    }
}
