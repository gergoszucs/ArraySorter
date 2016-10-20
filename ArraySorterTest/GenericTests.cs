using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorter;
using System.Linq;

namespace ArraySorterTest
{
    [TestClass]
    public class GenericTests
    { 
        [TestMethod]
        public void TestInteger()
        {
            int[] unsortedArray = { 3, 6, 1, 8, 2, 4, 9, 5, 7 };

            CollectionAssert.AreEqual(new ArraySorter<int>().SortArray(unsortedArray, Algorithms.Insertion), unsortedArray.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestFloat()
        {
            float[] unsortedArray = { 3.6f, 6.6f, 1.1f, 3.8f, 6.2f, 6.0f, 9.5f, 2.2f, 7.9f };

            CollectionAssert.AreEqual(new ArraySorter<float>().SortArray(unsortedArray, Algorithms.Quick), unsortedArray.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestDouble()
        {
            double[] unsortedArray = { 3.4, 6.1, 1.7, 3.2, 6.2, 6.0, 9.8, 2.0, 7.4 };

            CollectionAssert.AreEqual(new ArraySorter<double>().SortArray(unsortedArray, Algorithms.Heap), unsortedArray.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestString()
        {
            string[] unsortedArray = { "c", "h", "a", "g", "f", "z", "b", "p" };

            CollectionAssert.AreEqual(new ArraySorter<string>().SortArray(unsortedArray, Algorithms.Merge), unsortedArray.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void TestChar()
        {
            char[] unsortedArray = { 'c', 'h', 'a', 'g', 'f', 'z', 'b', 'p' };

            CollectionAssert.AreEqual(new ArraySorter<char>().SortArray(unsortedArray, Algorithms.Bubble), unsortedArray.OrderBy(x => x).ToArray());
        }
    }
}
