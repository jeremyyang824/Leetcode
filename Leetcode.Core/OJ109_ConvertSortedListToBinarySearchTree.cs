using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
     */
    public class OJ109_ConvertSortedListToBinarySearchTree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
                return null;
            return this.generateBST(head, null);
        }

        private TreeNode generateBST(ListNode begin, ListNode end)
        {
            if (begin == end)
                return null;

            ListNode currentNode = begin;
            ListNode currentNodeHalf = begin;
            int i = 0;
            while (currentNode.next != end)
            {
                if (++i % 2 == 0)
                    currentNodeHalf = currentNodeHalf.next;
                currentNode = currentNode.next;
            }

            TreeNode node = new TreeNode(currentNodeHalf.val);
            node.left = generateBST(begin, currentNodeHalf);
            node.right = generateBST(currentNodeHalf.next, end);
            return node;
        }
    }
}
