using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ100_SameTreeTest
    {
        [TestMethod]
        public void OJ100_SameTreeTest1()
        {
            TreeNode p = new TreeNode(5);
            p.left = new TreeNode(3);
            p.right = new TreeNode(8);
            p.right.left = new TreeNode(4);

            TreeNode q = new TreeNode(5);
            q.left = new TreeNode(3);
            q.right = new TreeNode(8);
            q.right.left = new TreeNode(4);

            bool result = new OJ100_SameTree().IsSameTree(p, q);
            Assert.AreEqual(true, result);
        }
    }
}
