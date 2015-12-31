using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ113_PathSumIITest
    {
        [TestMethod]
        public void OJ113_PathSumIITest1()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);

            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.left = new TreeNode(5);
            root.right.right.right = new TreeNode(1);

            IList<IList<int>> result = new OJ113_PathSumII().PathSum(root, 22);
            ArrayAssert.AreEqual(new int[] { 5, 4, 11, 2 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 5, 8, 4, 5 }, result[1].ToArray());
        }
    }
}
