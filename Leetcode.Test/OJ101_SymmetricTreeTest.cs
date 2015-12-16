using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ101_SymmetricTreeTest
    {
        [TestMethod]
        public void OJ101_SymmetricTreeTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            bool result = new OJ101_SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ101_SymmetricTreeTest2()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(2);
            root.right.right = new TreeNode(3);

            bool result = new OJ101_SymmetricTree().IsSymmetric(root);
            Assert.AreEqual(false, result);
        }
    }
}
