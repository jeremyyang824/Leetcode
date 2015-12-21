using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ107_BinaryTreeLevelOrderTraversalIITest
    {
        [TestMethod]
        public void OJ107_BinaryTreeLevelOrderTraversalIITest1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            IList<IList<int>> result = new OJ107_BinaryTreeLevelOrderTraversalII().LevelOrderBottom(root);
            ArrayAssert.AreEqual(new int[] { 15, 7 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 9, 20 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 3 }, result[2].ToArray());
        }
    }
}
