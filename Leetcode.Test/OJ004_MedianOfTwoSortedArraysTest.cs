using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ004_MedianOfTwoSortedArraysTest
    {
        [TestMethod]
        public void OJ004_MedianOfTwoSortedArraysTest1()
        {
            int[] arr1 = new int[] { 1, 5, 8, 12 };
            int[] arr2 = new int[] { -2, 3, 5, 12, 18 };
            double result = new OJ004_MedianOfTwoSortedArrays().FindMedianSortedArrays(arr1, arr2);

            //-2, 1, 3, 5, [5], 8, 12, 12, 18
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void OJ004_MedianOfTwoSortedArraysTest2()
        {
            int[] arr1 = new int[] { 1, 5, 6, 8, 12 };
            int[] arr2 = new int[] { -2, 3, 5, 12, 18 };
            double result = new OJ004_MedianOfTwoSortedArrays().FindMedianSortedArrays(arr1, arr2);

            //-2, 1, 3, 5, [5, 6], 8, 12, 12, 18
            Assert.AreEqual(5.5, result);
        }
    }
}
