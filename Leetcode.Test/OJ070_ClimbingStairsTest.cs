using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ070_ClimbingStairsTest
    {
        [TestMethod]
        public void OJ070_ClimbingStairsTest1()
        {
            int result = new OJ070_ClimbingStairs().ClimbStairs(5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void OJ070_ClimbingStairsTest2()
        {
            int result = new OJ070_ClimbingStairs().ClimbStairs(1);
            Assert.AreEqual(1, result);
        }
    }
}
