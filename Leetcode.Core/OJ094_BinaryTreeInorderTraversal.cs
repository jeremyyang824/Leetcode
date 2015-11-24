using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, return the inorder traversal of its nodes' values.
     * For example:
     * Given binary tree {1,#,2,3},
     * 1
     *  \
     *   2
     *  /
     * 3
     * return [1,3,2].
     * Note: Recursive solution is trivial, could you do it iteratively?
     */
    public class OJ094_BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
                return result;

            inorderTraversal(root, result);
            return result;
        }

        private void inorderTraversal(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;
            this.inorderTraversal(root.left, result);
            result.Add(root.val);
            this.inorderTraversal(root.right, result);
        }

        //非递归版本
        /*
         * 对于任一结点P：
         * 1)若其左孩子不为空，则将P入栈并将P的左孩子置为当前的P，然后对当前结点P再进行相同的处理；
         * 2)若其左孩子为空，则取栈顶元素并进行出栈操作，访问该栈顶结点，然后将当前的P置为栈顶结点的右孩子；
         * 3)直到P为NULL并且栈为空则遍历结束
         */
        public IList<int> InorderTraversal2(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
                return result;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                if (stack.Count > 0)
                {
                    current = stack.Pop();
                    result.Add(current.val);    //访问节点
                    current = current.right;
                }
            }

            return result;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
}
