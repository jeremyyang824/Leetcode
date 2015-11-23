using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ091_DecodeWaysTest
    {
        [TestMethod]
        public void OJ091_DecodeWaysTest1()
        {
            int result = new OJ091_DecodeWays().NumDecodings("12");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OJ091_DecodeWaysTest2()
        {
            int result = new OJ091_DecodeWays().NumDecodings("123");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void OJ091_DecodeWaysTest3()
        {
            int result = new OJ091_DecodeWays().NumDecodings("1234");
            Assert.AreEqual(3, result);
        }
    }
}
