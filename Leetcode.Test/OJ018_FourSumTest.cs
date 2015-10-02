using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ018_FourSumTest
    {
        [TestMethod]
        public void OJ018_FourSumTest1()
        {
            IList<IList<int>> result = new OJ018_FourSum().FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);

            Assert.AreEqual(3, result.Count);

            Assert.AreEqual(-2, result[0][0]);
            Assert.AreEqual(-1, result[0][1]);
            Assert.AreEqual(1, result[0][2]);
            Assert.AreEqual(2, result[0][3]);

            Assert.AreEqual(-2, result[1][0]);
            Assert.AreEqual(0, result[1][1]);
            Assert.AreEqual(0, result[1][2]);
            Assert.AreEqual(2, result[1][3]);

            Assert.AreEqual(-1, result[2][0]);
            Assert.AreEqual(0, result[2][1]);
            Assert.AreEqual(0, result[2][2]);
            Assert.AreEqual(1, result[2][3]);
        }
    }
}
