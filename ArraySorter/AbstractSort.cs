using System;

namespace ArraySorter
{
    /// <summary>
    /// Abstract class for the sorting algorithms
    /// </summary>
    /// <typeparam name="T">Generic type, must implement the IComparable interface</typeparam>
    abstract class AbstractSort<T> : ISortingAlgorithm<T> where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Abstract Sort method, it has to be defined by each subclass
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <returns>Returns the sorted array of the original values</returns>
        public abstract T[] Sort(T[] unsortedArray);

        /// <summary>
        /// Sorts the array of elements given in the first parameter
        /// and fills the second paramater with the original order of these values.
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <param name="originalOrder">Original order of the sorted values</param>
        /// <returns>Returns the sorted array of the original values</returns>
        public T[] Sort(T[] unsortedArray, out int[] originalOrder)
        {
            T[] sortedArray = Sort((T[])unsortedArray.Clone());
            originalOrder = new int[unsortedArray.Length];

            var counter = 0;

            foreach (T element in sortedArray)
            {
                for (var i = 0; i < unsortedArray.Length; i++)
                {
                    if (element.Equals(unsortedArray[i]))
                    {
                        originalOrder[counter++] = i + 1;
                        break;
                    }
                }
            }

            return sortedArray;
        }
    }
}
