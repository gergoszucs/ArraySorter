using System;


namespace ArraySorter
{
    // This is only used to generate the namespace comment with SandCastle.
    /// <summary>
    /// Contains multiple generic sorting algorithms which arw working on an array.
    /// The overloaded sort method can also specify the original order of the sorted values.
    /// </summary>
    internal class NamespaceDoc
    {

    }

    /// <summary>
    /// Generic array sorter class. The generic type must implement the IComparable interface
    /// </summary>
    /// <typeparam name="T">Generic type, must implement the IComparable interface</typeparam>
    public class ArraySorter<T> where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Sorts the array provided in the first parameter using the algorithm specified by the second parameter
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <param name="algorithm">The selected sorting algorithm</param>
        /// <returns>Returns the sorted array of the original values</returns>
        public T[] SortArray(T[] unsortedArray, Algorithms algorithm)
        {
            T[] values = (T[])unsortedArray.Clone();
            
            switch (algorithm)
            {
                case Algorithms.Bubble:
                    return new BubbleSort<T>().Sort(values);
                case Algorithms.Heap:
                    return new HeapSort<T>().Sort(values);
                case Algorithms.Insertion:
                    return new InsertionSort<T>().Sort(values);
                case Algorithms.Merge:
                    return new MergeSort<T>().Sort(values);
                case Algorithms.Quick:
                    return new QuickSort<T>().Sort(values);
                default:
                    throw new IllegalAlgorithmException("Unrecognized algorithm name");
            }
        }

        /// <summary>
        /// Sorts the array provided in the first parameter using the algorithm specified by the second parameter.
        /// The third value must be passed as an out integer array, it will contain the original order of the sorted values.
        /// </summary>
        /// <param name="unsortedArray">Array of the values to be sorted</param>
        /// <param name="algorithm">The selected sorting algorithm</param>
        /// <param name="originalOrder">Original order of the sorted values</param>
        /// <returns>Returns the sorted array of the original values</returns>
        public T[] SortArray(T[] unsortedArray, Algorithms algorithm, out int[] originalOrder)
        {
            T[] values = (T[])unsortedArray.Clone();

            switch (algorithm)
            {
                case Algorithms.Bubble:
                    return new BubbleSort<T>().Sort(values, out originalOrder);
                case Algorithms.Heap:
                    return new HeapSort<T>().Sort(values, out originalOrder);
                case Algorithms.Insertion:
                    return new InsertionSort<T>().Sort(values, out originalOrder);
                case Algorithms.Merge:
                    return new MergeSort<T>().Sort(values, out originalOrder);
                case Algorithms.Quick:
                    return new QuickSort<T>().Sort(values, out originalOrder);
                default:
                    throw new IllegalAlgorithmException("Unrecognized algorithm name");
            }
        }
    }
}
