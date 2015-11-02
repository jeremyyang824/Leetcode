using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ059_SpiralMatrixIITest
    {
        [TestMethod]
        public void OJ059_SpiralMatrixIITest1()
        {
            int[,] result = new OJ059_SpiralMatrixII().GenerateMatrix(3);
            Assert.AreEqual(3, result.Rank + 1);

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(3, result[0, 2]);
            Assert.AreEqual(8, result[1, 0]);
            Assert.AreEqual(9, result[1, 1]);
            Assert.AreEqual(4, result[1, 2]);
            Assert.AreEqual(7, result[2, 0]);
            Assert.AreEqual(6, result[2, 1]);
            Assert.AreEqual(5, result[2, 2]);
        }
    }
}
