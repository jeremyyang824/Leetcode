using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ102_BinaryTreeLevelOrderTraversalTest
    {
        [TestMethod]
        public void OJ102_BinaryTreeLevelOrderTraversalTest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            IList<IList<int>> result = new OJ102_BinaryTreeLevelOrderTraversal().LevelOrder(root);
            ArrayAssert.AreEqual(new int[] { 3 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 9, 20 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 15, 7 }, result[2].ToArray());
        }
    }
}
