using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Reverse a linked list from position m to n. Do it in-place and in one-pass.
     * For example:
     * Given 1->2->3->4->5->NULL, m = 2 and n = 4,
     * return 1->4->3->2->5->NULL.
     * 
     * Note:
     * Given m, n satisfy the following condition:
     * 1 ≤ m ≤ n ≤ length of list.
     */
    public class OJ092_ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;

            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;

            int i = 0;
            for (; i < m - 1; i++)
            {
                prev = current;
                current = current.next;
            }

            ListNode h = prev;
            ListNode hn = current;
            for (; i < n && current != null; i++)
            {
                next = current.next;
                current.next = prev;

                prev = current;
                current = next;
            }

            if (h != null)
                h.next = prev;
            else
                head = prev;
            hn.next = current;

            return head;
        }
    }
}
