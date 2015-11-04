using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ064_MinimumPathSumTest
    {
        [TestMethod]
        public void OJ064_MinimumPathSumTest1()
        {
            int result = new OJ064_MinimumPathSum().MinPathSum(new int[,] { 
                {1, 2, 3},
                {3, 0, 1},
                {4, 1, 2},
            });
            Assert.AreEqual(6, result);
        }
    }
}
