using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ097_InterleavingStringTest
    {
        [TestMethod]
        public void OJ097_InterleavingStringTest1()
        {
            bool result = new OJ097_InterleavingString().IsInterleave("aabcc", "dbbca", "aadbbcbcac");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ097_InterleavingStringTest2()
        {
            bool result = new OJ097_InterleavingString().IsInterleave("aabcc", "dbbca", "aadbbbaccc");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ097_InterleavingStringTest3()
        {
            bool result = new OJ097_InterleavingString().IsInterleave("a", "", "a");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ097_InterleavingStringTest4()
        {
            bool result = new OJ097_InterleavingString().IsInterleave("ab", "bc", "babc");
            Assert.AreEqual(true, result);
        }
    }
}
