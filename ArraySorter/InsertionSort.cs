using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class InsertionSort<T> : AbstractSort<T> where T : IComparable, IComparable<T>
    {
        public override T[] Sort(T[] arr)
        {
            T temp;
            int j;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                j = i + 1;

                while (j > 0)
                {
                    if (Comparer<T>.Default.Compare(arr[j - 1], arr[j]) > 0)
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }

                    --j;
                }
            }

            return arr;
        }
    }
}
