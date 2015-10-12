using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ040_CombinationSumIITest
    {
        [TestMethod]
        public void OJ040_CombinationSumIITest1()
        {
            IList<IList<int>> result = new OJ040_CombinationSumII().CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
            Assert.AreEqual(4, result.Count);

            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(1, result[0][1]);
            Assert.AreEqual(6, result[0][2]);

            Assert.AreEqual(1, result[1][0]);
            Assert.AreEqual(2, result[1][1]);
            Assert.AreEqual(5, result[1][2]);

            Assert.AreEqual(1, result[2][0]);
            Assert.AreEqual(7, result[2][1]);

            Assert.AreEqual(2, result[3][0]);
            Assert.AreEqual(6, result[3][1]);
        }
    }
}
