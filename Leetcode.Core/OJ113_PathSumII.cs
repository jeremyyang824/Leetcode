using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
     * For example:
     * Given the below binary tree and sum = 22,
     *               5
     *              / \
     *             4   8
     *            /   / \
     *           11  13  4
     *          /  \    / \
     *         7    2  5   1  
     * return
     * [[5,4,11,2],[5,8,4,5]]
     */
    public class OJ113_PathSumII
    {
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null)
                return result;

            this.dfs(root, root.val, new List<int>() { root.val }, sum);
            return result;
        }

        private void dfs(TreeNode root, int currentSum, List<int> currentPath, int resultSum)
        {
            if (root.left == null && root.right == null && currentSum == resultSum)
            {
                int[] resultItem = new int[currentPath.Count];
                currentPath.CopyTo(resultItem);
                this.result.Add(resultItem);
                return;
            }

            if (root.left != null)
            {
                currentPath.Add(root.left.val);
                this.dfs(root.left, currentSum + root.left.val, currentPath, resultSum);
                currentPath.RemoveAt(currentPath.Count - 1);
            }
            if (root.right != null)
            {
                currentPath.Add(root.right.val);
                this.dfs(root.right, currentSum + root.right.val, currentPath, resultSum);
                currentPath.RemoveAt(currentPath.Count - 1);
            }
        }
    }
}
