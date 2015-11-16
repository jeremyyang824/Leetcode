using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ081_SearchInRotatedSortedArrayIITest
    {
        [TestMethod]
        public void OJ081_SearchInRotatedSortedArrayIITest1()
        {
            bool result = new OJ081_SearchInRotatedSortedArrayII().Search(new int[] { 5, 5, 5, 5, 1, 2, 3, 4 }, 4);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ081_SearchInRotatedSortedArrayIITest2()
        {
            bool result = new OJ081_SearchInRotatedSortedArrayII().Search(new int[] { 1, 3, 1, 1 }, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ081_SearchInRotatedSortedArrayIITest3()
        {
            bool result = new OJ081_SearchInRotatedSortedArrayII().Search(new int[] { 1 }, 0);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ081_SearchInRotatedSortedArrayIITest4()
        {
            bool result = new OJ081_SearchInRotatedSortedArrayII().Search(new int[] { 1 }, 1);
            Assert.AreEqual(true, result);
        }
    }
}
