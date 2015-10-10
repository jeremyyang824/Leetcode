using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ034_SearchForARangeTest
    {
        [TestMethod]
        public void OJ034_SearchForARangeTest1()
        {
            int[] result = new OJ034_SearchForARange().SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [TestMethod]
        public void OJ034_SearchForARangeTest2()
        {
            int[] result = new OJ034_SearchForARange().SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 12);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }
    }
}
