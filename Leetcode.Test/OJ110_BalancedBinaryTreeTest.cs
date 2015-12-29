using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ110_BalancedBinaryTreeTest
    {
        [TestMethod]
        public void OJ110_BalancedBinaryTreeTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.left.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            bool result = new OJ110_BalancedBinaryTree().IsBalanced(root);
            Assert.AreEqual(true, result);
        }
    }
}
