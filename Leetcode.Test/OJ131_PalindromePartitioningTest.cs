using System;
using System.Collections.Generic;
using Leetcode.Core;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ131_PalindromePartitioningTest
    {
        [TestMethod]
        public void OJ131_PalindromePartitioningTest1()
        {
            IList<IList<string>> result = new OJ131_PalindromePartitioning().Partition("aab");
            ArrayAssert.AreEqual(new string[] { "aa", "b" }, result[1].ToArray());
            ArrayAssert.AreEqual(new string[] { "a", "a", "b" }, result[0].ToArray());
        }
    }
}
