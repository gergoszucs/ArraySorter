using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ArraySorter;

namespace ArraySorterTest
{
    [TestClass]
    public class AlgorithmTests
    {
        ArraySorter<int> sorter;
        int[] integers, sortedIntegers;
        int[] equalIntegers, sortedEqualIntegers;

        public AlgorithmTests()
        {
            sorter = new ArraySorter<int>();

            integers = new[] { 9, 5, 1, 6, 2, 4, 3, 8, 7 };
            equalIntegers = new[] { 9, 5, 9, 8, 2, 9, 5, 8, 2 };

            sortedIntegers = integers.OrderBy(x => x).ToArray();
            sortedEqualIntegers = equalIntegers.OrderBy(x => x).ToArray();
        }

        [TestInitialize]
        public void Initialize()
        {
            // Recreate the original values before running each test, just to make sure we are not overwriting the arrays
            integers = new[] { 9, 5, 1, 6, 2, 4, 3, 8, 7 };
            equalIntegers = new[] { 9, 5, 9, 8, 2, 9, 5, 8, 2 };
        }

        [TestMethod]
        public void BubbleSort()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Bubble), sortedIntegers);
        }

        [TestMethod]
        public void HeapSort()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Heap), sortedIntegers);
        }

        [TestMethod]
        public void InsertionSort()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Insertion), sortedIntegers);
        }

        [TestMethod]
        public void MergeSort()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Merge), sortedIntegers);
        }

        [TestMethod]
        public void QuickSort()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Quick), sortedIntegers);
        }

        [TestMethod]
        public void BubbleSortWithEqualValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(equalIntegers, Algorithms.Bubble), sortedEqualIntegers);
        }

        [TestMethod]
        public void HeapSortWithEqualValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(equalIntegers, Algorithms.Heap), sortedEqualIntegers);
        }

        [TestMethod]
        public void InsertionSortWithEqualValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(equalIntegers, Algorithms.Insertion), sortedEqualIntegers);
        }

        [TestMethod]
        public void MergeSortWithEqualValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(equalIntegers, Algorithms.Merge), sortedEqualIntegers);
        }

        [TestMethod]
        public void QuickSortWithEqualValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(equalIntegers, Algorithms.Quick), sortedEqualIntegers);
        }
    }
}
