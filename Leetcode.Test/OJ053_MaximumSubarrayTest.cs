using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ053_MaximumSubarrayTest
    {
        [TestMethod]
        public void OJ053_MaximumSubarrayTest1()
        {
            int result = new OJ053_MaximumSubarray().MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.AreEqual(6, result); //4,-1,2,1
        }

        [TestMethod]
        public void OJ053_MaximumSubarrayTest2()
        {
            int result = new OJ053_MaximumSubarray().MaxSubArray(new int[] { 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OJ053_MaximumSubarrayTest3()
        {
            int result = new OJ053_MaximumSubarray().MaxSubArray(new int[] { -1 });
            Assert.AreEqual(-1, result);
        }
    }
}
