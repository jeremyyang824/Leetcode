using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, find its minimum depth.
     * The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
     */
    public class OJ111_MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            this.dfs(root, 1);
            return minDepth;
        }

        int minDepth = int.MaxValue;
        private void dfs(TreeNode root, int currentDepth)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                minDepth = Math.Min(minDepth, currentDepth);
                return;
            }
            else
            {
                this.dfs(root.left, currentDepth + 1);
                this.dfs(root.right, currentDepth + 1);
            }
        }
    }
}
