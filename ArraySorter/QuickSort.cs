using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class QuickSort<T> : AbstractSort<T> where T : IComparable, IComparable<T>
    {
        public override T[] Sort(T[] arr)
        {
            SortQuick(arr, 0, arr.Length - 1);

            return arr;
        }

        private int Partition(T[] arr, int left, int right)
        {
            T pivot = arr[left];

            while (true)
            {
                while (arr[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                    
                while (arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                    
                if (left < right)
                {
                    T temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private void SortQuick(T[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    SortQuick(arr, left, pivot - 1);
                }
                    
                if (pivot + 1 < right)
                {
                    SortQuick(arr, pivot + 1, right);
                }  
            }
        }
    }
}
