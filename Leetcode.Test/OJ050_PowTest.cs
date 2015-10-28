using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ050_PowTest
    {
        [TestMethod]
        public void OJ050_PowTest1()
        {
            double result = new OJ050_Pow().MyPow(3, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ050_PowTest2()
        {
            double result = new OJ050_Pow().MyPow(3, 3);
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void OJ050_PowTest3()
        {
            double result = new OJ050_Pow().MyPow(2, -2);
            Assert.AreEqual(0.25, result);
        }

        [TestMethod]
        public void OJ050_PowTest4()
        {
            double result = new OJ050_Pow().MyPow(2, -1);
            Assert.AreEqual(0.5, result);
        }
    }
}
