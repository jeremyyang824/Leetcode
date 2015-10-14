using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ043_MultiplyStringsTest
    {
        [TestMethod]
        public void OJ043_MultiplyStringsTest1()
        {
            string result = new OJ043_MultiplyStrings().Multiply("362", "9327");
            Assert.AreEqual("3376374", result);
        }

        [TestMethod]
        public void OJ043_MultiplyStringsTest2()
        {
            string result = new OJ043_MultiplyStrings().Multiply("000", "0000");
            Assert.AreEqual("0", result);
        }
    }
}
