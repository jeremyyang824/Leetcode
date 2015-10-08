using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ031_NextPermutationTest
    {
        [TestMethod]
        public void OJ031_NextPermutationTest1()
        {
            int[] result = new int[] { 1, 2, 3 };
            new OJ031_NextPermutation().NextPermutation(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(2, result[2]);
        }

        [TestMethod]
        public void OJ031_NextPermutationTest2()
        {
            int[] result = new int[] { 3, 2, 1 };
            new OJ031_NextPermutation().NextPermutation(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
        }

        [TestMethod]
        public void OJ031_NextPermutationTest3()
        {
            int[] result = new int[] { 1, 1, 5 };
            new OJ031_NextPermutation().NextPermutation(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(5, result[1]);
            Assert.AreEqual(1, result[2]);
        }
    }
}
