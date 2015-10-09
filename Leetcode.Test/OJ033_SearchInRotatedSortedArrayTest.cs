using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ033_SearchInRotatedSortedArrayTest
    {
        [TestMethod]
        public void OJ033_SearchInRotatedSortedArrayTest1()
        {
            int result = new OJ033_SearchInRotatedSortedArray().Search(new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2 }, 5);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ033_SearchInRotatedSortedArrayTest2()
        {
            int result = new OJ033_SearchInRotatedSortedArray().Search(new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2 }, 1);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void OJ033_SearchInRotatedSortedArrayTest3()
        {
            int result = new OJ033_SearchInRotatedSortedArray().Search(new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2 }, 3);
            Assert.AreEqual(-1, result);
        }
    }
}
