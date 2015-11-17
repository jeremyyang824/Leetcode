using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
     * For example,
     * Given 1->2->3->3->4->4->5, return 1->2->5.
     * Given 1->1->1->2->3, return 2->3.
     */
    public class OJ082_RemoveDuplicatesFromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode newHead = new ListNode(-1);
            newHead.next = head;

            ListNode prev = newHead;
            ListNode current = head;
            while (current != null)
            {
                if (current.next != null && current.next.val == current.val)
                {
                    while (current.next != null && current.next.val == current.val)
                        current = current.next;

                    prev.next = current.next;
                    current = current.next;
                }
                else
                {
                    prev = prev.next;
                    current = current.next;
                }

            }
            return newHead.next;
        }
    }
}
