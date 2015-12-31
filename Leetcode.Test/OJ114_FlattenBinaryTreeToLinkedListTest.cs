using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ114_FlattenBinaryTreeToLinkedListTest
    {
        [TestMethod]
        public void OJ114_FlattenBinaryTreeToLinkedListTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);

            root.right = new TreeNode(5);
            root.right.right = new TreeNode(6);

            new OJ114_FlattenBinaryTreeToLinkedList().Flatten(root);

            Assert.AreEqual(1, root.val);

            Assert.AreEqual(null, root.left);
            Assert.AreEqual(2, root.right.val);

            Assert.AreEqual(null, root.right.left);
            Assert.AreEqual(3, root.right.right.val);

            Assert.AreEqual(null, root.right.right.left);
            Assert.AreEqual(4, root.right.right.right.val);

            Assert.AreEqual(null, root.right.right.right.left);
            Assert.AreEqual(5, root.right.right.right.right.val);

            Assert.AreEqual(null, root.right.right.right.right.left);
            Assert.AreEqual(6, root.right.right.right.right.right.val);
        }
    }
}
