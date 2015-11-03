using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a list, rotate the list to the right by k places, where k is non-negative.
     * 
     * For example:
     * Given 1->2->3->4->5->NULL and k = 2,
     * return 4->5->1->2->3->NULL.
     */
    public class OJ061_RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)
                return head;

            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            k = k % count;
            if (k == 0)
                return head;

            ListNode first = head;
            while (k-- > 0)
                first = first.next;

            ListNode second = head;
            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }

            ListNode result = second.next;
            first.next = head;
            second.next = null;
            return result;
        }
    }
}
