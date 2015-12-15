using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ099_RecoverBinarySearchTreeTest
    {
        [TestMethod]
        public void OJ099_RecoverBinarySearchTreeTest1()
        {
            TreeNode tree = new TreeNode(8);
            tree.left = new TreeNode(5);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(10);
            tree.right = new TreeNode(6);

            new OJ099_RecoverBinarySearchTree().RecoverTree(tree);

            Assert.AreEqual(tree.val, 8);
            Assert.AreEqual(tree.left.val, 5);
            Assert.AreEqual(tree.left.left.val, 3);
            Assert.AreEqual(tree.left.right.val, 6);
            Assert.AreEqual(tree.right.val, 10);
        }
    }
}
