using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given inorder and postorder traversal of a tree, construct the binary tree.
     * Note:
     * You may assume that duplicates do not exist in the tree.
     */
    public class OJ106_ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length < 1)
                return null;
            return buildTree(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
        }

        private TreeNode buildTree(int[] inorder, int[] postorder, int iStart, int iEnd, int pStart, int pEnd)
        {
            if (pStart > pEnd)
                return null;

            int root = postorder[pEnd];
            int i = iStart;
            for (; i <= iEnd; i++)
            {
                if (inorder[i] == root)
                    break;
            }

            TreeNode rootNode = new TreeNode(root);
            int rightLen = iEnd - i;
            rootNode.left = buildTree(inorder, postorder, iStart, i - 1, pStart, pEnd - rightLen - 1);
            rootNode.right = buildTree(inorder, postorder, i + 1, iEnd, pEnd - rightLen, pEnd - 1);
            return rootNode;
        }
    }
}
