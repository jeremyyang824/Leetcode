using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, flatten it to a linked list in-place.
     * For example,
     * Given
     *          1
     *         / \
     *        2   5
     *       / \   \
     *      3   4   6
     * The flattened tree should look like:
     *    1
     *     \
     *      2
     *       \
     *        3
     *         \
     *          4
     *           \
     *            5
     *             \
     *              6
     */
    public class OJ114_FlattenBinaryTreeToLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            this.dfs(root);
        }

        private TreeNode dfs(TreeNode root)
        {
            TreeNode end = root;

            TreeNode leftBegin = root.left;
            root.left = null;
            TreeNode rightBegin = root.right;
            root.right = null;

            if (leftBegin != null)
            {
                TreeNode leftEnd = dfs(leftBegin);
                end.right = leftBegin;
                end = leftEnd;
            }
            if (rightBegin != null)
            {
                TreeNode rightEnd = dfs(rightBegin);
                end.right = rightBegin;
                end = rightEnd;
            }

            return end;
        }
    }
}
