using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.
     * Return a deep copy of the list.
     */
    public class OJ138_CopyListWithRandomPointer
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (head == null)
                return null;

            RandomListNode newHead = null;
            RandomListNode
                pOld = head,
                pNew = newHead,
                pOldNext = null;

            //初始化
            do
            {
                pOldNext = pOld.next;
                pNew = new RandomListNode(pOld.label);
                pOld.next = pNew;
                pNew.next = pOldNext;

                if (newHead == null)
                    newHead = pNew; //设置头指针
                pOld = pOldNext;
            }
            while (pOld != null);

            //设置new list的random指针
            pOld = head;
            while (pOld != null)
            {
                if (pOld.random != null)
                    pOld.next.random = pOld.random.next;
                pOld = pOld.next.next;
            }

            //恢复old list和new list
            pOld = head;
            pNew = newHead;
            while (pNew.next != null)
            {
                pOld.next = pNew.next;
                pOld = pOld.next;

                pNew.next = pOld.next;
                pNew = pNew.next;
            }
            pOld.next = null;
            pNew.next = null;

            return newHead;
        }
    }

    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x)
        {
            this.label = x;
        }
    };
}
