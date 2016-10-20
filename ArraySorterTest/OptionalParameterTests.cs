using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorter;

namespace ArraySorterTest
{
    [TestClass]
    public class OptionalParameterTests
    {
        [TestMethod]
        public void InsertionWithOptional()
        {
            int[] unsortedArray = { 2, 6, 1, 4, 2, 1, 6, 2, 1 };
            int[] originalOrder = { 3, 6, 9, 1, 5, 8, 4, 2, 7 };
            int[] calculatedOrder;

            new ArraySorter<int>().SortArray(unsortedArray, Algorithms.Insertion, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }

        [TestMethod]
        public void QuickWithOptional()
        {
            float[] unsortedArray = { 3.6f, 6.6f, 3.6f, 4.9f, 6.6f, 4.9f, 4.9f, 6.6f, 3.6f };
            int[] originalOrder = { 1, 3, 9, 4, 6, 7, 2, 5, 8 };
            int[] calculatedOrder;

            new ArraySorter<float>().SortArray(unsortedArray, Algorithms.Quick, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }

        [TestMethod]
        public void HeapWithOptional()
        {
            double[] unsortedArray = { 3.6, 6.6, 3.6, 4.9, 6.6, 4.9, 4.9, 6.6, 3.6 };
            int[] originalOrder = { 1, 3, 9, 4, 6, 7, 2, 5, 8 };
            int[] calculatedOrder;

            new ArraySorter<double>().SortArray(unsortedArray, Algorithms.Heap, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }

        [TestMethod]
        public void MergeWithOptional()
        {
            string[] unsortedArray = { "c", "b", "d", "b", "c", "d", "b", "c" };
            int[] originalOrder = { 2, 4, 7, 1, 5, 8, 3, 6};
            int[] calculatedOrder;

            new ArraySorter<string>().SortArray(unsortedArray, Algorithms.Merge, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }

        [TestMethod]
        public void BubbleWithOptional()
        {
            char[] unsortedArray = { 'c', 'b', 'd', 'b', 'c', 'd', 'b', 'c' };
            int[] originalOrder = { 2, 4, 7, 1, 5, 8, 3, 6 };
            int[] calculatedOrder;

            new ArraySorter<char>().SortArray(unsortedArray, Algorithms.Bubble, out calculatedOrder);
            CollectionAssert.AreEqual(originalOrder, calculatedOrder);
        }
    }
}
