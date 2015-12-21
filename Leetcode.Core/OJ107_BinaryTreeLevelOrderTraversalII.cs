using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
     * For example:
     * Given binary tree {3,9,20,#,#,15,7},
     *     3
     *    / \
     *   9  20
     *     /  \
     *    15   7
     * return its bottom-up level order traversal as:
     * [[15,7],[9,20],[3]]
     */
    public class OJ107_BinaryTreeLevelOrderTraversalII
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Stack<IList<int>> stack = new Stack<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                IList<int> items = new List<int>();
                int num = queue.Count;
                for (int i = 0; i < num; i++)
                {
                    TreeNode node = queue.Dequeue();
                    items.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                stack.Push(items);
            }

            while (stack.Count > 0)
                result.Add(stack.Pop());

            return result;
        }
    }
}
