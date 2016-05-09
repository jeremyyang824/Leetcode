using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
     * An example is the root-to-leaf path 1->2->3 which represents the number 123.
     * Find the total sum of all root-to-leaf numbers.
     * 
     * For example,
     *     1
     *    / \
     *   2   3
     * The root-to-leaf path 1->2 represents the number 12.
     * The root-to-leaf path 1->3 represents the number 13.
     * Return the sum = 12 + 13 = 25.
     */
    public class OJ129_SumRootToLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
                return 0;
            return dfs(root, 0);
        }

        private int dfs(TreeNode node, int sum)
        {
            if (node == null)
                return 0;
            sum = sum * 10 + node.val;
            if (node.left == null && node.right == null)
                return sum;

            int left = dfs(node.left, sum);
            int right = dfs(node.right, sum);
            return left + right;
        }
    }
}
