using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ191_HammingWeightTest
    {
        [TestMethod]
        public void OJ191_HammingWeightTest1()
        {
            int result = new OJ191_HammingWeight().HammingWeight(11);
            Assert.AreEqual(3, result);
        }
    }
}
