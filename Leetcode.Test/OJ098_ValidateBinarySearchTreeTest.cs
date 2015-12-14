using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ098_ValidateBinarySearchTreeTest
    {
        [TestMethod]
        public void OJ098_ValidateBinarySearchTreeTest1()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(8);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(10);

            bool result = new OJ098_ValidateBinarySearchTree().IsValidBST(root);
            Assert.AreEqual(true, result);
        }
    }
}
