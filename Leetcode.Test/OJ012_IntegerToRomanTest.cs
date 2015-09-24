using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ012_IntegerToRomanTest
    {
        [TestMethod]
        public void OJ012_IntegerToRomanTest1()
        {
            string result = new OJ012_IntegerToRoman().IntToRoman(3852);
            Assert.AreEqual("MMMDCCCLII", result);
        }
    }
}
