using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ023_MergeKSortedListsTest
    {
        [TestMethod]
        public void OJ023_MergeKSortedListsTest1()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(3);
            l1.next.next = new ListNode(12);
            l1.next.next.next = new ListNode(14);

            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(8);
            l2.next.next = new ListNode(12);

            ListNode l3 = new ListNode(3);
            l3.next = new ListNode(5);
            l3.next.next = new ListNode(11);

            ListNode result = new OJ023_MergeKSortedLists().MergeKLists(new ListNode[] { l1, l2, l3 });
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(5, result.next.next.next.next.val);
            Assert.AreEqual(8, result.next.next.next.next.next.val);
            Assert.AreEqual(11, result.next.next.next.next.next.next.val);
            Assert.AreEqual(12, result.next.next.next.next.next.next.next.val);
            Assert.AreEqual(12, result.next.next.next.next.next.next.next.next.val);
            Assert.AreEqual(14, result.next.next.next.next.next.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next.next.next.next.next.next);
        }

        [TestMethod]
        public void OJ023_MergeKSortedListsTest2()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(0);
            ListNode l5 = new ListNode(0);
            ListNode result = new OJ023_MergeKSortedLists().MergeKLists(new ListNode[] { l1, l2, l3, l4, l5 });
            Assert.AreEqual(0, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(1, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(3, result.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next);
        }

        [TestMethod]
        public void MinHeapTest()
        {
            MinHeap<int> heap = new MinHeap<int>(10);
            heap.Push(5);
            heap.Push(8);
            heap.Push(3);
            Assert.AreEqual(3, heap.Length);
            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(2, heap.Length);
            Assert.AreEqual(5, heap.Pop());
            Assert.AreEqual(1, heap.Length);
            heap.Push(7);
            heap.Push(4);
            Assert.AreEqual(3, heap.Length);
            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(7, heap.Pop());
            Assert.AreEqual(8, heap.Pop());
            Assert.AreEqual(0, heap.Length);
        }
    }
}
