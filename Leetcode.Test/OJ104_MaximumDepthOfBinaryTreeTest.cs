using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ104_MaximumDepthOfBinaryTreeTest
    {
        [TestMethod]
        public void OJ104_MaximumDepthOfBinaryTreeTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            int result = new OJ104_MaximumDepthOfBinaryTree().MaxDepth(root);
            Assert.AreEqual(3, result);
        }
    }
}
