using System;
using System.Collections;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ039_CombinationSumTest
    {
        [TestMethod]
        public void OJ039_CombinationSumTest1()
        {
            IList<IList<int>> result = new OJ039_CombinationSum().CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            Assert.AreEqual(2, result.Count);

            Assert.AreEqual(2, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(3, result[0][2]);

            Assert.AreEqual(7, result[1][0]);
        }
    }
}
