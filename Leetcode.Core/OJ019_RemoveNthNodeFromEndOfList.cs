using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a linked list, remove the nth node from the end of list and return its head.
     * For example：
     * Given linked list: 1->2->3->4->5, and n = 2.
     * After removing the second node from the end, the linked list becomes 1->2->3->5.
     * 
     * Note:
     * Given n will always be valid.
     * Try to do this in one pass.
     */
    public class OJ019_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            ListNode p1 = head;
            ListNode p2 = head;

            int i = n;
            while (i-- > 0)
                p1 = p1.next;

            if (p1 == null)
                return p2.next;

            while (p1.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            p2.next = p2.next.next;
            return head;
        }
    }
}
