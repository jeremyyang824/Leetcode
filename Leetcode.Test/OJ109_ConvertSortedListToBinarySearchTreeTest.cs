using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ109_ConvertSortedListToBinarySearchTreeTest
    {
        [TestMethod]
        public void OJ109_ConvertSortedListToBinarySearchTreeTest1()
        {
            ListNode n = new ListNode(1);
            n.Next(2).Next(3).Next(4).Next(5).Next(6);
            TreeNode result = new OJ109_ConvertSortedListToBinarySearchTree().SortedListToBST(n);

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(1, result.left.val);
            Assert.AreEqual(2, result.left.right.val);
            Assert.AreEqual(5, result.right.val);
            Assert.AreEqual(4, result.right.left.val);
            Assert.AreEqual(6, result.right.right.val);
        }
    }
}
