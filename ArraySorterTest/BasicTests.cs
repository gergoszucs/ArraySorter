using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorter;

namespace ArraySorterTest
{
    [TestClass]
    public class BasicTests
    {
        int[] unsortedArray, originalOrder, calculatedOrder;

        public BasicTests()
        {
            originalOrder = new int[] { 3, 8, 4, 7, 1, 5, 2, 6 };
        }

        [TestInitialize]
        public void Initialize()
        {
            unsortedArray = new int[] { 3, 4, 1, 2, 3, 4, 2, 1 };
        }

        [TestMethod]
        public void EmptyArray()
        {
            CollectionAssert.AreEqual(new ArraySorter<int>().SortArray(new int[] { }, Algorithms.Insertion), new int[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(IllegalAlgorithmException))]
        public void NonExistingAlgorithm()
        {
            new ArraySorter<int>().SortArray(unsortedArray, (Algorithms)42);
        }

        [TestMethod]
        public void NonEmptyOptionalParameter()
        {
            calculatedOrder = new int[]{ 2, 4, 7, 1, 5, 8, 3, 6 };

            new ArraySorter<int>().SortArray(unsortedArray, Algorithms.Bubble, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }

        [TestMethod]
        public void OriginalValueEqualsOptionalParameter()
        {
            new ArraySorter<int>().SortArray(unsortedArray, Algorithms.Bubble, out unsortedArray);
            CollectionAssert.AreEqual(originalOrder, unsortedArray);
        }
    }
}
