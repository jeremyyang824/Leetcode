using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Two elements of a binary search tree (BST) are swapped by mistake.
     * Recover the tree without changing its structure.
     * Note:
     * A solution using O(n) space is pretty straight forward. Could you devise a constant space solution?
     */
    public class OJ099_RecoverBinarySearchTree
    {
        /*
         *  因为 BST 的中序遍历是一个递增的数组, 
         *  当数组中连续的两个数被交换时, 只会出现一次逆序,否则, 必然恰好两次逆序。
         *  
         *  设置两个指针p和q来存储逆序对，
         *      第一次逆序对中的前一个节点为错误节点，
         *      第二次逆序对中的后一个节点为错误节点（如果存在的话）。
         */

        TreeNode p, q;
        TreeNode prev;

        public void RecoverTree(TreeNode root)
        {
            this.inOrder(root);

            int temp = p.val;
            p.val = q.val;
            q.val = temp;
        }

        private void inOrder(TreeNode root)
        {
            if (root.left != null)
                inOrder(root.left);

            if (prev != null && prev.val > root.val)
            {
                if (p == null)
                    p = prev;
                q = root;
            }
            prev = root;

            if (root.right != null)
                inOrder(root.right);
        }
    }
}
