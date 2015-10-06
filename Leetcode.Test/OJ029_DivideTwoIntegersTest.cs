using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ029_DivideTwoIntegersTest
    {
        [TestMethod]
        public void OJ029_DivideTwoIntegersTest1()
        {
            int result = new OJ029_DivideTwoIntegers().Divide(102, 4);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void OJ029_DivideTwoIntegersTest2()
        {
            int result = new OJ029_DivideTwoIntegers().Divide(9, 3);
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void OJ029_DivideTwoIntegersTest3()
        {
            int result = new OJ029_DivideTwoIntegers().Divide(9, -3);
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void OJ029_DivideTwoIntegersTest4()
        {
            int result = new OJ029_DivideTwoIntegers().Divide(-2147483648, -1);
            Assert.AreEqual(int.MaxValue, result);
        }
    }
}
