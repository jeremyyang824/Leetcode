using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ123_BestTimeToBuyAndSellStockIIITest
    {
        [TestMethod]
        public void OJ123_BestTimeToBuyAndSellStockIIITest1()
        {
            int result = new OJ123_BestTimeToBuyAndSellStockIII().MaxProfit(new int[] { 14, 12, 13, 15, 14, 16, 10, 8, 12 });
            Assert.AreEqual(8, result);
        }
    }
}
