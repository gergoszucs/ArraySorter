using System;

namespace ArraySorter
{
    /// <summary>
    /// Generic interface for the sorting algorithms.
    /// The type must implement the IComparable interface.
    /// </summary>
    /// <typeparam name="T">Generic type, must implement the IComparable interface</typeparam>
    interface ISortingAlgorithm<T> where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Sorts a generic array based on their existing CompareTo method.
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <returns>The sorted array of the original elements.</returns>
        T[] Sort(T[] unsortedArray);

        /// <summary>
        /// Sorts a generic array based on their existing CompareTo method.
        /// Also creates an auxilary array containing the original position of the sorted values.
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <param name="originalOrder">Original order of the sorted values</param>
        /// <returns>The sorted array of the original elements.</returns>
        T[] Sort(T[] unsortedArray, out int[] originalOrder);
    }
}
