using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorter;
using System.Linq;
using System;
using System.Diagnostics;

namespace ArraySorterTest
{
    [TestClass]
    public class RandomTests
    {
        ArraySorter<int> sorter;
        Random randNum;
        int[] integers, sortedIntegers;
        int valueCount;

        public RandomTests()
        {
            sorter = new ArraySorter<int>();
            valueCount = 2000;
            randNum = new Random();
        }

        [TestInitialize]
        public void Initialize()
        {
            integers = Enumerable
                .Repeat(0, valueCount)
                .Select(i => randNum.Next(-30000, 30000))
                .ToArray();

            sortedIntegers = integers.OrderBy(x => x).ToArray();
        }

        [TestMethod]
        public void BubbleSortWithNegativeValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Bubble), sortedIntegers);
        }

        [TestMethod]
        public void HeapSortWithNegativeValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Heap), sortedIntegers);
        }

        [TestMethod]
        public void InsertionSortWithNegativeValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Insertion), sortedIntegers);
        }

        [TestMethod]
        public void MergeSortWithNegativeValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Merge), sortedIntegers);
        }

        [TestMethod]
        public void QuickSortWithNegativeValues()
        {
            CollectionAssert.AreEqual(sorter.SortArray(integers, Algorithms.Quick), sortedIntegers);
        }
    }
}
