using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ008_StringToIntegerTest
    {
        [TestMethod]
        public void OJ008_StringToIntegerTest1()
        {
            int result = new OJ008_StringToInteger().MyAtoi("  +123456");
            Assert.AreEqual(123456, result);
        }

        [TestMethod]
        public void OJ008_StringToIntegerTest2()
        {
            int result = new OJ008_StringToInteger().MyAtoi("b1234");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OJ008_StringToIntegerTest3()
        {
            int result = new OJ008_StringToInteger().MyAtoi("  12a12");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void OJ008_StringToIntegerTest4()
        {
            int result = new OJ008_StringToInteger().MyAtoi("3000000001");
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void OJ008_StringToIntegerTest5()
        {
            int result = new OJ008_StringToInteger().MyAtoi("-3000000001");
            Assert.AreEqual(int.MinValue, result);
        }
    }
}
