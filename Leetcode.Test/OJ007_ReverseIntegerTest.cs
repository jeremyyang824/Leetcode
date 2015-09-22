using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ007_ReverseIntegerTest
    {
        [TestMethod]
        public void OJ007_ReverseIntegerTest1()
        {
            int result = new OJ007_ReverseInteger().Reverse(123);
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void OJ007_ReverseIntegerTest2()
        {
            int result = new OJ007_ReverseInteger().Reverse(-123);
            Assert.AreEqual(-321, result);
        }

        [TestMethod]
        public void OJ007_ReverseIntegerTest3()
        {
            int result = new OJ007_ReverseInteger().Reverse(100);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ007_ReverseIntegerTest4()
        {
            //int32.MaxVal = 2147483647 (2^32 - 1) 
            int result = new OJ007_ReverseInteger().Reverse(1000000003);
            Assert.AreEqual(0, result); //overflow
        }
    }
}
