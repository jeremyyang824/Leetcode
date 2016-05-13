using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ132_PalindromePartitioningIITest
    {
        [TestMethod]
        public void OJ132_PalindromePartitioningIITest1()
        {
            int result = new OJ132_PalindromePartitioningII().MinCut("aab");
            Assert.AreEqual(1, result);
        }
    }
}
