using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ077_CombinationsTest
    {
        [TestMethod]
        public void OJ077_CombinationsTest1()
        {
            var result = new OJ077_Combinations().Combine(4, 2)
                .OrderBy(r => r[0]).ThenBy(r => r[1]).ToArray();

            Assert.AreEqual(6, result.Count());
            ArrayAssert.AreEqual(new int[] { 1, 2 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 3 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 4 }, result[2].ToArray());
            ArrayAssert.AreEqual(new int[] { 2, 3 }, result[3].ToArray());
            ArrayAssert.AreEqual(new int[] { 2, 4 }, result[4].ToArray());
            ArrayAssert.AreEqual(new int[] { 3, 4 }, result[5].ToArray());
        }

        [TestMethod]
        public void OJ077_CombinationsTest2()
        {
            var result = new OJ077_Combinations().Combine(4, 3)
                .OrderBy(r => r[0]).ThenBy(r => r[1]).ThenBy(r => r[2]).ToArray();

            Assert.AreEqual(4, result.Count());
            ArrayAssert.AreEqual(new int[] { 1, 2, 3 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2, 4 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 3, 4 }, result[2].ToArray());
            ArrayAssert.AreEqual(new int[] { 2, 3, 4 }, result[3].ToArray());
        }
    }
}
