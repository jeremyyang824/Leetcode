using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ069_SqrtXTest
    {
        [TestMethod]
        public void OJ069_SqrtXTest1()
        {
            int result = new OJ069_SqrtX().MySqrt(9);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void OJ069_SqrtXTest2()
        {
            int result = new OJ069_SqrtX().MySqrt(2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ069_SqrtXTest3()
        {
            int result = new OJ069_SqrtX().MySqrt(2147483647);
            Assert.AreEqual(46340, result);
        }
    }
}
