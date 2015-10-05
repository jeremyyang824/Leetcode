using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
     * If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
     * You may not alter the values in the nodes, only nodes itself may be changed.
     * Only constant memory is allowed.
     * 
     * For example,
     * Given this linked list: 1->2->3->4->5
     * For k = 2, you should return: 2->1->4->3->5
     * For k = 3, you should return: 3->2->1->4->5
     */
    public class OJ025_ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;

            ListNode result = new ListNode(0);
            result.next = head;

            ListNode pre = null;
            ListNode cur = head;
            ListNode next = null;
            ListNode end = null;
            head = result;

            while (cur != null)
            {
                int i = k;
                end = cur;
                while (--i > 0 && end != null)
                {
                    end = end.next;
                }
                if (end == null) return head.next;

                i = k;
                while (i-- > 0)
                {
                    next = cur.next;
                    cur.next = pre;
                    pre = cur;
                    cur = next;
                }
                result.next.next = cur;
                ListNode t = result.next;
                result.next = pre;
                result = t;
            }

            return head.next;  
        }

    }
}
