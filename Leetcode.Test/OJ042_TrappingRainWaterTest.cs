using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ042_TrappingRainWaterTest
    {
        [TestMethod]
        public void OJ042_TrappingRainWaterTest1()
        {
            int result = new OJ042_TrappingRainWater().Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Assert.AreEqual(6, result);
        }
    }
}
