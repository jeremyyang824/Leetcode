using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ112_PathSumTest
    {
        [TestMethod]
        public void OJ112_PathSumTest1()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);

            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(1);

            bool result = new OJ112_PathSum().HasPathSum(root, 22);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ112_PathSumTest2()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(6);

            bool result = new OJ112_PathSum().HasPathSum(root, 9);
            Assert.AreEqual(true, result);
        }
    }
}
