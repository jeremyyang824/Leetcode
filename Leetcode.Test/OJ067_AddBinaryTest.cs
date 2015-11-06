using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ067_AddBinaryTest
    {
        [TestMethod]
        public void OJ067_AddBinaryTest1()
        {
            string result = new OJ067_AddBinary().AddBinary("11", "1");
            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void OJ067_AddBinaryTest2()
        {
            string result = new OJ067_AddBinary().AddBinary("1001", "1");
            Assert.AreEqual("1010", result);
        }

        [TestMethod]
        public void OJ067_AddBinaryTest3()
        {
            string result = new OJ067_AddBinary().AddBinary("1", "1001");
            Assert.AreEqual("1010", result);
        }
    }
}
