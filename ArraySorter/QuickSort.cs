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
            SortQuick(arr, 0, arr.Length);

            return arr;
        }

        private int Partition(T[] arr, int left, int right)
        {
            T pivot = arr[left];
            int start = left;
            left++;
            right--;

            while (true)
            {
                while (left <= right && arr[left].CompareTo(pivot) <= 0)
                {
                    left++;
                }
                    
                while (left <= right && arr[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                    
                if (left > right)
                {
                    arr[start] = arr[left - 1];
                    arr[left - 1] = pivot;

                    return left;
                }

                T temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
        }

        private void SortQuick(T[] arr, int left, int right)
        {
            if (arr == null || arr.Length <= 1)
            {
                return;
            }
                
            if (left < right)
            {
                int pivotIdx = Partition(arr, left, right);

                SortQuick(arr, left, pivotIdx - 1);
                SortQuick(arr, pivotIdx, right);  
            }
        }
    }
}
