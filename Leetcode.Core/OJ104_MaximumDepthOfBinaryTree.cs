using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, find its maximum depth.
     * The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
     */
    public class OJ104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return this.dfs(root, 1);
        }

        private int dfs(TreeNode root, int depth)
        {
            if (root == null)
                return depth;

            int leftDepth = depth;
            if (root.left != null)
                leftDepth = this.dfs(root.left, depth + 1);

            int rightDepth = depth;
            if (root.right != null)
                rightDepth = this.dfs(root.right, depth + 1);

            return Math.Max(leftDepth, rightDepth);
        }
    }
}
