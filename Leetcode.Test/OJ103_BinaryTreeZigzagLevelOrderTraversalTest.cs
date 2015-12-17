using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ103_BinaryTreeZigzagLevelOrderTraversalTest
    {
        [TestMethod]
        public void OJ103_BinaryTreeZigzagLevelOrderTraversalTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            IList<IList<int>> result = new OJ103_BinaryTreeZigzagLevelOrderTraversal().ZigzagLevelOrder(root);
            ArrayAssert.AreEqual(new int[] { 3 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 20, 9 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 15, 7 }, result[2].ToArray());
        }
    }
}
