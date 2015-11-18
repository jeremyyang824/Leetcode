using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
     * You should preserve the original relative order of the nodes in each of the two partitions.
     * For example,
     * Given 1->4->3->2->5->2 and x = 3,
     * return 1->2->2->4->3->5.
     */
    public class OJ086_PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
                return null;

            ListNode sm = new ListNode(0);
            ListNode sm_tail = sm;
            ListNode gt = new ListNode(0);
            ListNode gt_tail = gt;

            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val < x)
                {
                    sm_tail.next = curr;
                    curr = curr.next;
                    sm_tail = sm_tail.next;
                    sm_tail.next = null;
                }
                else
                {
                    gt_tail.next = curr;
                    curr = curr.next;
                    gt_tail = gt_tail.next;
                    gt_tail.next = null;
                }
            }

            sm_tail.next = gt.next;
            return sm.next;
        }
    }
}
