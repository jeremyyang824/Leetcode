using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a linked list, swap every two adjacent nodes and return its head.
     * For example,
     * Given 1->2->3->4, you should return the list as 2->1->4->3.
     * Your algorithm should use only constant space. 
     * You may not modify the values in the list, only nodes itself can be changed.
     */
    public class OJ024_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode first = head;
            ListNode second = head.next;
            head = second;
            ListNode prev = null;
            while (first != null && second != null)
            {
                first.next = second.next;
                second.next = first;

                if (prev != null)
                {
                    prev.next = second;
                }
                prev = first;

                first = first.next;
                if (first != null)
                    second = first.next;
            }
            return head;
        }
    }
}
