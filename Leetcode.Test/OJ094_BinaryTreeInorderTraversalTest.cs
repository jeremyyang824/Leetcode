using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ094_BinaryTreeInorderTraversalTest
    {
        [TestMethod]
        public void OJ094_BinaryTreeInorderTraversalTest1()
        {
            TreeNode tn = new TreeNode(1);
            tn.right = new TreeNode(2);
            tn.right.left = new TreeNode(3);
            IList<int> result = new OJ094_BinaryTreeInorderTraversal().InorderTraversal2(tn);
            ArrayAssert.AreEqual(new int[] { 1, 3, 2 }, result.ToArray());
        }
    }
}
