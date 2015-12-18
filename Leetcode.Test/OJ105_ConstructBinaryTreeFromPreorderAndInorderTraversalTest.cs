using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ105_ConstructBinaryTreeFromPreorderAndInorderTraversalTest
    {
        [TestMethod]
        public void OJ105_ConstructBinaryTreeFromPreorderAndInorderTraversalTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            TreeNode result = new OJ105_ConstructBinaryTreeFromPreorderAndInorderTraversal().BuildTree(
                new int[] { 3, 9, 20, 15, 7 },
                new int[] { 9, 3, 15, 20, 7 });

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(9, result.left.val);
            Assert.AreEqual(20, result.right.val);
            Assert.AreEqual(15, result.right.left.val);
            Assert.AreEqual(7, result.right.right.val);
        }
    }
}
