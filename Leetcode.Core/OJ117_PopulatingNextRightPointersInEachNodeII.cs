using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Follow up for problem "Populating Next Right Pointers in Each Node".
     * What if the given tree could be any binary tree? Would your previous solution still work?
     * 
     * Note: You may only use constant extra space.
     * For example,
     * Given the following binary tree,
     *          1
     *        /  \
     *       2    3
     *      / \    \
     *     4   5    7
     * After calling your function, the tree should look like:
     *          1 -> NULL
     *        /  \
     *       2 -> 3 -> NULL
     *      / \    \
     *     4-> 5 -> 7 -> NULL
     */
    public class OJ117_PopulatingNextRightPointersInEachNodeII
    {
        public void connect(TreeLinkNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return;

            TreeLinkNode current = null;
            if (root.left != null && root.right != null)
            {
                root.left.next = root.right;
                current = root.right;
            }
            else
            {
                current = root.left != null ? root.left : root.right;
            }

            TreeLinkNode rootNext = root.next;
            while (rootNext != null)
            {
                if (rootNext.left != null || rootNext.right != null)
                {
                    current.next = rootNext.left != null ? rootNext.left : rootNext.right;
                    break;
                }
                rootNext = rootNext.next;
            }

            connect(root.right);    //先连右边！！！
            connect(root.left);
        }
    }
}
