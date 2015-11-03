using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ062_UniquePathsTest
    {
        [TestMethod]
        public void OJ062_UniquePathsTest1()
        {
            int result = new OJ062_UniquePaths().UniquePaths(3, 7);
            Assert.AreEqual(28, result);
        }
    }
}
