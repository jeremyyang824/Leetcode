using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ013_RomanToIntegerTest
    {
        [TestMethod]
        public void OJ013_RomanToIntegerTest1()
        {
            int result = new OJ013_RomanToInteger().RomanToInt("MMMDCCCLII");
            Assert.AreEqual(3852, result);
        }
    }
}
