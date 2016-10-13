using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class HeapSort<T> : AbstractSort<T> where T : IComparable, IComparable<T>
    {
        private int heapSize;

        public override T[] Sort(T[] arr)
        {
            BuildHeap(arr);

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }

            return arr;
        }

        private void BuildHeap(T[] arr)
        {
            heapSize = arr.Length - 1;

            for (var i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap(T[] arr, int x, int y)
        {
            T temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        private void Heapify(T[] arr, int index)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var largest = index;

            if (left <= heapSize && arr[left].CompareTo(arr[index]) > 0)
            {
                largest = left;
            }

            if (right <= heapSize && arr[right].CompareTo(arr[largest]) > 0)
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
    }
}
