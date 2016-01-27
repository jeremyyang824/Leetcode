using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ117_PopulatingNextRightPointersInEachNodeIITest
    {
        [TestMethod]
        public void OJ117_PopulatingNextRightPointersInEachNodeIITest1()
        {
            TreeLinkNode root = new TreeLinkNode(1);
            root.left = new TreeLinkNode(2);
            root.right = new TreeLinkNode(3);
            root.left.left = new TreeLinkNode(4);
            root.left.right = new TreeLinkNode(5);
            root.right.right = new TreeLinkNode(7);
            new OJ117_PopulatingNextRightPointersInEachNodeII().connect(root);

            Assert.AreEqual(3, root.left.next.val);
            Assert.AreEqual(5, root.left.left.next.val);
            Assert.AreEqual(7, root.left.left.next.next.val);
        }

        /*
         *          1
         *        /  \
         *       2    3
         *      / \    \
         *     4   5    6
         *    /          \
         *   7            8
         */
        [TestMethod]
        public void OJ117_PopulatingNextRightPointersInEachNodeIITest2()
        {
            TreeLinkNode root = new TreeLinkNode(1);
            root.left = new TreeLinkNode(2);
            root.right = new TreeLinkNode(3);

            root.left.left = new TreeLinkNode(4);
            root.left.right = new TreeLinkNode(5);

            root.right.right = new TreeLinkNode(6);

            root.left.left.left = new TreeLinkNode(7);
            root.right.right.right = new TreeLinkNode(8);
            new OJ117_PopulatingNextRightPointersInEachNodeII().connect(root);

            Assert.AreEqual(8, root.left.left.left.next.val);

        }
    }
}
