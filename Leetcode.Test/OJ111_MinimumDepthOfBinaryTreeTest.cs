using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ111_MinimumDepthOfBinaryTreeTest
    {
        [TestMethod]
        public void OJ111_MinimumDepthOfBinaryTreeTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.left.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            int result = new OJ111_MinimumDepthOfBinaryTree().MinDepth(root);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void OJ111_MinimumDepthOfBinaryTreeTest2()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);

            int result = new OJ111_MinimumDepthOfBinaryTree().MinDepth(root);
            Assert.AreEqual(2, result);
        }
    }
}
