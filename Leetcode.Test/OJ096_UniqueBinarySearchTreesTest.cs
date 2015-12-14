using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ096_UniqueBinarySearchTreesTest
    {
        [TestMethod]
        public void OJ096_UniqueBinarySearchTreesTest1()
        {
            int result = new OJ096_UniqueBinarySearchTrees().NumTrees(3);
            Assert.AreEqual(5, result);
        }
    }
}
