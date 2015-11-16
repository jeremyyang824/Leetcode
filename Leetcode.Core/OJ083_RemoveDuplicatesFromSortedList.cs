using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a sorted linked list, delete all duplicates such that each element appear only once.
     * For example,
     * Given 1->1->2, return 1->2.
     * Given 1->1->2->3->3, return 1->2->3.
     */
    public class OJ083_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            ListNode prev = head;
            ListNode current = head.next;
            while (current != null)
            {
                if (current.val == prev.val)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = current;
                }
                current = current.next;
            }
            return head;
        }
    }
}
