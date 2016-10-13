using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class BubbleSort<T> : AbstractSort<T> where T : IComparable, IComparable<T>
    {
        public override T[] Sort(T[] arr)
        {
            T temp;

            for (var write = 0; write < arr.Length; write++)
            {
                for (var sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort].CompareTo(arr[sort + 1]) > 0)
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
