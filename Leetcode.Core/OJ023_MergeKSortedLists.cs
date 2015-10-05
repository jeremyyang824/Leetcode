using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Merge k sorted linked lists and return it as one sorted list. 
     * Analyze and describe its complexity.
     */
    public class OJ023_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;

            MinHeap<SortedNode> heap = new MinHeap<SortedNode>(10000);
            for (int i = 0; i < lists.Length; i++)
            {
                ListNode li = lists[i];
                if (li != null)
                {
                    heap.Push(new SortedNode(li));
                }
            }

            while (heap.Length > 0)
            {
                ListNode min = heap.Pop().Node;
                current.next = min;
                current = current.next;

                if (min.next != null)
                {
                    heap.Push(new SortedNode(min.next));
                }
            }

            return result.next;
        }
    }

    public class SortedNode : IComparable<SortedNode>
    {
        public ListNode Node { get; private set; }

        public SortedNode(ListNode n)
        {
            this.Node = n;
        }

        public int CompareTo(SortedNode other)
        {
            if (this.Node.val < other.Node.val)
                return -1;
            else if (this.Node.val > other.Node.val)
                return 1;
            else
                return 0;
        }
    }

    public class MinHeap<Key>
        where Key : IComparable<Key>
    {
        private Key[] pq;
        private int num = 0;

        public int Length
        {
            get { return this.num; }
        }

        public MinHeap(int max)
        {
            pq = new Key[max + 1];
        }

        public void Push(Key v)
        {
            this.pq[++num] = v;
            this.swin(num);
        }

        public Key Pop()
        {
            Key min = this.pq[1];
            this.pq[1] = this.pq[num--];
            this.sink(1);
            return min;
        }

        private void swin(int k)
        {
            while (k / 2 > 0 && less(k, k / 2))
            {
                this.exch(k, k / 2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (k * 2 <= this.num)
            {
                int j = k * 2;
                if (j + 1 <= num && less(j + 1, j))
                    j = j + 1;

                if (less(k, j))
                    break;

                this.exch(k, j);
                k = j;
            }
        }

        private bool less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        private void exch(int i, int j)
        {
            Key t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }
    }
}
