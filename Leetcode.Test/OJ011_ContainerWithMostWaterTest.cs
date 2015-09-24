using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ011_ContainerWithMostWaterTest
    {
        [TestMethod]
        public void OJ011_ContainerWithMostWaterTest1()
        {
            int[] height = new int[] { 6, 1, 3, 5, };
            int result = new OJ011_ContainerWithMostWater().MaxArea(height);
            Assert.AreEqual(3 * 5, result);
        }

        [TestMethod]
        public void OJ011_ContainerWithMostWaterTest2()
        {
            int[] height = new int[] { 5, 1, 4, 10, 5, };
            int result = new OJ011_ContainerWithMostWater().MaxArea(height);
            Assert.AreEqual(20, result);

        }
    }
}
