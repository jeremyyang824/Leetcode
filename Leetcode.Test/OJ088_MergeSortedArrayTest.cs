using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ088_MergeSortedArrayTest
    {
        [TestMethod]
        public void OJ088_MergeSortedArrayTest1()
        {
            int[] arr1 = new int[6] { 1, 3, 5, 0, 0, 0 };
            int[] arr2 = new int[] { 2, 7, 8 };
            new OJ088_MergeSortedArray().Merge(arr1, 3, arr2, 3);

            ArrayAssert.AreEqual(new int[] { 1, 2, 3, 5, 7, 8 }, arr1);
        }
    }
}
