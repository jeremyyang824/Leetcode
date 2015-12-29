using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, determine if it is height-balanced.
     * For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
     */
    public class OJ110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            if (!IsBalanced(root.left) || !IsBalanced(root.right))
                return false;

            int leftHeight = 0;
            if (root.left != null)
                leftHeight = this.getTreeHeight(root.left);

            int rightHeight = 0;
            if (root.right != null)
                rightHeight = this.getTreeHeight(root.right);

            return Math.Abs(leftHeight - rightHeight) <= 1;
        }

        private int getTreeHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = this.getTreeHeight(root.left);
            int rightHeight = this.getTreeHeight(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
