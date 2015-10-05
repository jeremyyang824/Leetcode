using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Reverse a singly linked list.
     */
    public class OJ206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;

                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
