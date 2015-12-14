using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ095_UniqueBinarySearchTreesIITest
    {
        [TestMethod]
        public void OJ095_UniqueBinarySearchTreesIITest1()
        {
            IList<TreeNode> result = new OJ095_UniqueBinarySearchTreesII().GenerateTrees(3);
            Assert.AreEqual(5, result.Count);
        }
    }
}
