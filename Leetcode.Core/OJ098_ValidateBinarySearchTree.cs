using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, determine if it is a valid binary search tree (BST).
     * 
     * Assume a BST is defined as follows:
     * The left subtree of a node contains only nodes with keys less than the node's key.
     * The right subtree of a node contains only nodes with keys greater than the node's key.
     * Both the left and right subtrees must also be binary search trees.
     */
    public class OJ098_ValidateBinarySearchTree
    {
        List<int> list = new List<int>();

        /*
         * 二分查找树的中序遍历结果是一个递增序列
         */
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null)
                return true;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] <= list[i - 1]) 
                    return false;
            }
            return true;
        }

        public void inOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            inOrderTraversal(node.left);
            list.Add(node.val);
            inOrderTraversal(node.right);
        }
    }
}
