using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
     * For example, this binary tree is symmetric:
     *     1
     *    / \
     *   2   2
     *  / \ / \
     * 3  4 4  3
     * But the following is not:
     *     1
     *    / \
     *   2   2
     *    \   \
     *     3    3
     *     
     * Note:
     * Bonus points if you could solve it both recursively and iteratively.
     */
    public class OJ101_SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return isSymmetric(root.left, root.right);
        }

        private bool isSymmetric(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            else if (t1 == null || t2 == null)
                return false;

            if (t1.val != t2.val)
                return false;

            return isSymmetric(t1.left, t2.right) && isSymmetric(t1.right, t2.left);
        }
    }
}
