using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ084_LargestRectangleInHistogramTest
    {
        [TestMethod]
        public void OJ084_LargestRectangleInHistogramTest1()
        {
            int result = new OJ084_LargestRectangleInHistogram().LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 });
            Assert.AreEqual(10, result);
        }
    }
}
