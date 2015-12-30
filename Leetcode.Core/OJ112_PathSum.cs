using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.
     * For example:
     * Given the below binary tree and sum = 22,
     *               5
     *              / \
     *             4   8
     *            /   / \
     *           11  13  4
     *          /  \      \
     *         7    2      1
     */
    public class OJ112_PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            return dfs(root, root.val, sum);
        }

        private bool dfs(TreeNode root, int currentSum, int resultSum)
        {
            if (root.left == null && root.right == null && currentSum == resultSum)
                return true;

            if (root.left != null && this.dfs(root.left, currentSum + root.left.val, resultSum))
                return true;
            if (root.right != null && this.dfs(root.right, currentSum + root.right.val, resultSum))
                return true;

            return false;
        }
    }
}
