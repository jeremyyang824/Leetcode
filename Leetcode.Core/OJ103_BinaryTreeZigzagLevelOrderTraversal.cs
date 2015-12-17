using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a binary tree, return the zigzag level order traversal of its nodes' values. 
     * (ie, from left to right, then right to left for the next level and alternate between).
     * For example:
     * Given binary tree {3,9,20,#,#,15,7},
     *     3
     *    / \
     *   9  20
     *     /  \
     *    15   7
     * return its zigzag level order traversal as:
     * [[3],[20,9],[15,7]]
     */
    public class OJ103_BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool isReverse = false;
            while (queue.Count > 0)
            {
                List<int> arr = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    arr.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                if (isReverse)
                    arr.Reverse();
                isReverse = !isReverse;
                result.Add(arr);
            }
            return result;
        }
    }
}
