using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ124_BinaryTreeMaximumPathSumTest
    {
        [TestMethod]
        public void OJ124_BinaryTreeMaximumPathSumTest1()
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            int result = new OJ124_BinaryTreeMaximumPathSum().MaxPathSum(tree);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void OJ124_BinaryTreeMaximumPathSumTest2()
        {
            TreeNode tree = new TreeNode(-3);
            int result = new OJ124_BinaryTreeMaximumPathSum().MaxPathSum(tree);
            Assert.AreEqual(-3, result);
        }
    }
}
