using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ106_ConstructBinaryTreeFromInorderAndPostorderTraversalTest
    {
        [TestMethod]
        public void OJ106_ConstructBinaryTreeFromInorderAndPostorderTraversalTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            TreeNode result = new OJ106_ConstructBinaryTreeFromInorderAndPostorderTraversal().BuildTree(
                new int[] { 9, 3, 15, 20, 7 },
                new int[] { 9, 15, 7, 20, 3 });

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(9, result.left.val);
            Assert.AreEqual(20, result.right.val);
            Assert.AreEqual(15, result.right.left.val);
            Assert.AreEqual(7, result.right.right.val);
        }
    }
}
