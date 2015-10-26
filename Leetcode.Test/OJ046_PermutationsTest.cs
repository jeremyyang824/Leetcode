using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ046_PermutationsTest
    {
        [TestMethod]
        public void OJ046_PermutationsTest1()
        {
            IList<IList<int>> result = new OJ046_Permutations().Permute(new int[] { 1, 2, 3 });
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(3, result[0][2]);

            Assert.AreEqual(1, result[1][0]);
            Assert.AreEqual(3, result[1][1]);
            Assert.AreEqual(2, result[1][2]);

            Assert.AreEqual(2, result[2][0]);
            Assert.AreEqual(1, result[2][1]);
            Assert.AreEqual(3, result[2][2]);

            Assert.AreEqual(2, result[3][0]);
            Assert.AreEqual(3, result[3][1]);
            Assert.AreEqual(1, result[3][2]);

            Assert.AreEqual(3, result[4][0]);
            Assert.AreEqual(2, result[4][1]);
            Assert.AreEqual(1, result[4][2]);

            Assert.AreEqual(3, result[5][0]);
            Assert.AreEqual(1, result[5][1]);
            Assert.AreEqual(2, result[5][2]);
        }
    }
}
