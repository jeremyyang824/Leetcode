using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given preorder and inorder traversal of a tree, construct the binary tree.
     * Note:
     * You may assume that duplicates do not exist in the tree.
     */
    public class OJ105_ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length < 1)
                return null;

            return this.buildTree(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
        }

        private TreeNode buildTree(int[] preorder, int[] inorder, int pStart, int pEnd, int iStart, int iEnd)
        {
            if (pStart > pEnd)
                return null;

            int root = preorder[pStart];
            int i = iStart;
            for (; i <= iEnd; i++)
            {
                if (inorder[i] == root)
                    break;
            }

            TreeNode rootNode = new TreeNode(root);
            int leftLen = i - iStart;
            rootNode.left = buildTree(preorder, inorder, pStart + 1, pStart + leftLen, iStart, i - 1);
            rootNode.right = buildTree(preorder, inorder, pStart + leftLen + 1, pEnd, i + 1, iEnd);
            return rootNode;
        }
    }
}
