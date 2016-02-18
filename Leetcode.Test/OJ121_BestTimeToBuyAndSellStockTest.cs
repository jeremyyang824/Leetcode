using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ121_BestTimeToBuyAndSellStockTest
    {
        [TestMethod]
        public void OJ121_BestTimeToBuyAndSellStockTest1()
        {
            int result = new OJ121_BestTimeToBuyAndSellStock().MaxProfit(new int[] { 14, 12, 13, 15, 14, 16, 10, 8, 12 });
            Assert.AreEqual(4, result);
        }
    }
}
