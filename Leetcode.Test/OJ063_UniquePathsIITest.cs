using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ063_UniquePathsIITest
    {
        [TestMethod]
        public void OJ063_UniquePathsIITest1()
        {
            int result = new OJ063_UniquePathsII().UniquePathsWithObstacles(new int[,]{
                {0, 0, 0},
                {0, 1, 0},
                {0, 0, 0},
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OJ063_UniquePathsIITest2()
        {
            int result = new OJ063_UniquePathsII().UniquePathsWithObstacles(new int[,]{
                {1, 0},
            });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OJ063_UniquePathsIITest3()
        {
            int result = new OJ063_UniquePathsII().UniquePathsWithObstacles(new int[,]{
                {0},
                {1},
            });
            Assert.AreEqual(0, result);
        }
    }
}
