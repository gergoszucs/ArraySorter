using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class MergeSort<T> : AbstractSort<T> where T : IComparable, IComparable<T>
    {
        public override T[] Sort(T[] arr)
        {
            SortMerge(arr, 0, arr.Length - 1);

            return arr;
        }

        private void MainMerge(T[] arr, int left, int mid, int right)
        {
            T[] temp = new T[arr.Length];

            var eol = (mid - 1);
            var pos = left;
            var num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (arr[left].CompareTo(arr[mid]) <= 0)
                {
                    temp[pos++] = arr[left++];
                }
                else
                {
                    temp[pos++] = arr[mid++];
                }
            }

            while (left <= eol)
            {
                temp[pos++] = arr[left++];
            }

            while (mid <= right)
            {
                temp[pos++] = arr[mid++];
            }

            for (var i = 0; i < num; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }

        private void SortMerge(T[] arr, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(arr, left, mid);
                SortMerge(arr, (mid + 1), right);

                MainMerge(arr, left, (mid + 1), right);
            }
        }
    }
}
