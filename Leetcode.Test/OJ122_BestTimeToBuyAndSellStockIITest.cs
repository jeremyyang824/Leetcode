using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ122_BestTimeToBuyAndSellStockIITest
    {
        [TestMethod]
        public void OJ122_BestTimeToBuyAndSellStockIITest1()
        {
            int result = new OJ122_BestTimeToBuyAndSellStockII().MaxProfit(new int[] { 14, 12, 13, 15, 14, 16, 10, 8, 12 });
            Assert.AreEqual(9, result);
        }
    }
}
