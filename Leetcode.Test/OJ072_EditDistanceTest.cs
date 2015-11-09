using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ072_EditDistanceTest
    {
        [TestMethod]
        public void OJ072_EditDistanceTest1()
        {
            int result = new OJ072_EditDistance().MinDistance("abc", "adc");
            Assert.AreEqual(1, result);
        }
    }
}
