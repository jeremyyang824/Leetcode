﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree
     * struct TreeLinkNode {
     *  TreeLinkNode *left;
     *  TreeLinkNode *right;
     *  TreeLinkNode *next;
     * }
     * Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
     * Initially, all next pointers are set to NULL.
     * 
     * Note:
     * You may only use constant extra space.
     * You may assume that it is a perfect binary tree (ie, all leaves are at the same level, and every parent has two children).
     * For example,
     * Given the following perfect binary tree,
     * 
     *          1
     *        /  \
     *       2    3
     *      / \  / \
     *     4  5  6  7
     * After calling your function, the tree should look like:
     *          1 -> NULL
     *        /  \
     *       2 -> 3 -> NULL
     *      / \  / \
     *     4->5->6->7 -> NULL
     */
    public class OJ116_PopulatingNextRightPointersInEachNode
    {
        public void connect(TreeLinkNode root)
        {
            if (root == null || root.left == null)
                return; //完美树，如果没有左子，则一定没有右子

            root.left.next = root.right;
            if (root.next != null)
                root.right.next = root.next.left;

            connect(root.left);
            connect(root.right);
        }
    }

    public class TreeLinkNode
    {
        public int val;
        public TreeLinkNode left;
        public TreeLinkNode right;
        public TreeLinkNode next;

        public TreeLinkNode(int x)
        {
            val = x;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
