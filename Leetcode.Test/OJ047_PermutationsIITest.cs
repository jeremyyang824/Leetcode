using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ047_PermutationsIITest
    {
        [TestMethod]
        public void OJ047_PermutationsIITest1()
        {
            IList<IList<int>> result = new OJ047_PermutationsII().PermuteUnique(new int[] { 1, 1, 2 });

            Assert.AreEqual(3, result.Count);

            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(1, result[0][1]);
            Assert.AreEqual(2, result[0][2]);

            Assert.AreEqual(1, result[1][0]);
            Assert.AreEqual(2, result[1][1]);
            Assert.AreEqual(1, result[1][2]);

            Assert.AreEqual(2, result[2][0]);
            Assert.AreEqual(1, result[2][1]);
            Assert.AreEqual(1, result[2][2]);
        }

        [TestMethod]
        public void OJ047_PermutationsIITest2()
        {
            IList<IList<int>> result = new OJ047_PermutationsII().PermuteUnique(new int[] { 2, 2, 1, 1 });

            Assert.AreEqual(6, result.Count);

            ArrayAssert.AreEqual(new int[] { 1, 1, 2, 2 }, (int[])result[5]);
            ArrayAssert.AreEqual(new int[] { 1, 2, 1, 2 }, (int[])result[4]);
            ArrayAssert.AreEqual(new int[] { 1, 2, 2, 1 }, (int[])result[3]);
            ArrayAssert.AreEqual(new int[] { 2, 1, 1, 2 }, (int[])result[2]);
            ArrayAssert.AreEqual(new int[] { 2, 1, 2, 1 }, (int[])result[1]);
            ArrayAssert.AreEqual(new int[] { 2, 2, 1, 1 }, (int[])result[0]);
        }
    }
}
