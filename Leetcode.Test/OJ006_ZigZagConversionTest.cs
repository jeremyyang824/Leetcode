using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ006_ZigZagConversionTest
    {
        [TestMethod]
        public void OJ006_ZigZagConversionTest1()
        {
            string result = new OJ006_ZigZagConversion().Convert("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);
        }
    }
}

