using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * You are given two linked lists representing two non-negative numbers. 
     * The digits are stored in reverse order and each of their nodes contain a single digit. 
     * Add the two numbers and return it as a linked list.
     * 
     * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
     * Output: 7 -> 0 -> 8
     */
    public class OJ002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;
            while (true)
            {
                int sum = current.val;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                current.val = sum % 10;
                sum = sum / 10;

                if (l1 != null || l2 != null || sum != 0)
                {
                    current.next = new ListNode(sum);
                    current = current.next;
                }
                else
                    break;
            }
            return result;
        }
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class ListNodeHelper
    {
        public static ListNode Next(this ListNode prev, int x)
        {
            ListNode node = new ListNode(x);
            prev.next = node;
            return node;
        }
    }
}
