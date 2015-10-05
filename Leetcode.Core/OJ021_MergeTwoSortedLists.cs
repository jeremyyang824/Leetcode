using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Merge two sorted linked lists and return it as a new list. 
     * The new list should be made by splicing together the nodes of the first two lists.
     */
    public class OJ021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            ListNode lResult = new ListNode(0);
            ListNode l = lResult;
            while (true)
            {
                if (l1 == null)
                {
                    l.next = l2;
                    return lResult.next;
                }
                else if (l2 == null)
                {
                    l.next = l1;
                    return lResult.next;
                }
                else
                {
                    if (l1.val < l2.val)
                    {
                        l.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        l.next = l2;
                        l2 = l2.next;
                    }

                    l = l.next;
                }
            }
        }
    }
}
