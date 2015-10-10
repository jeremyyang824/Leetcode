using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ035_SearchInsertPositionTest
    {
        [TestMethod]
        public void OJ035_SearchInsertPositionTest1()
        {
            int result = new OJ035_SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OJ035_SearchInsertPositionTest2()
        {
            int result = new OJ035_SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ035_SearchInsertPositionTest3()
        {
            int result = new OJ035_SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void OJ035_SearchInsertPositionTest4()
        {
            int result = new OJ035_SearchInsertPosition().SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Assert.AreEqual(0, result);
        }
    }
}
