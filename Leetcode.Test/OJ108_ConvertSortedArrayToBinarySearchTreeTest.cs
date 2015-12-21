using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ108_ConvertSortedArrayToBinarySearchTreeTest
    {
        [TestMethod]
        public void OJ108_ConvertSortedArrayToBinarySearchTreeTest1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            TreeNode result = new OJ108_ConvertSortedArrayToBinarySearchTree().SortedArrayToBST(arr);

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(1, result.left.val);
            Assert.AreEqual(2, result.left.right.val);
            Assert.AreEqual(5, result.right.val);
            Assert.AreEqual(4, result.right.left.val);
            Assert.AreEqual(6, result.right.right.val);
        }
    }
}
