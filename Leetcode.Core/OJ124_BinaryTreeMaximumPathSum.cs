using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, find the maximum path sum.
     * For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. 
     * The path does not need to go through the root.
     * For example:
     * Given the below binary tree,
     *        1
     *       / \
     *      2   3
     * Return 6.
     */
    public class OJ124_BinaryTreeMaximumPathSum
    {
        /*
         * 假设最大路径经过某节点n，那么最大值max等于：
         *  若n的左子树路径>0，则加上左子树路径；
         *  若n的右子树路径>0，则加上右子树路径。
         *  其中，子树路径等于：
         *      子树根节点的左右子树路径最大值（小于0时为0） + 子树根
         */

        int maxVal = 0;
        public int MaxPathSum(TreeNode root)
        {
            if (root == null)
                return 0;

            maxVal = root.val;
            this.dfsPath(root);
            return maxVal;
        }

        private int dfsPath(TreeNode n)
        {
            if (n == null)
                return 0;
            int left = dfsPath(n.left);
            int right = dfsPath(n.right);

            int sum = n.val;
            if (left > 0) sum += left;
            if (right > 0) sum += right;
            if (sum > maxVal) maxVal = sum;

            return Math.Max(Math.Max(left, right), 0) + n.val;
        }
    }
}
