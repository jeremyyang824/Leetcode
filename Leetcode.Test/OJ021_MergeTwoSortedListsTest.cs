using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ021_MergeTwoSortedListsTest
    {
        [TestMethod]
        public void OJ021_MergeTwoSortedLists1()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(3);
            l1.next.next = new ListNode(12);
            l1.next.next.next = new ListNode(14);
            l1.next.next.next.next = new ListNode(15);

            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(8);
            l2.next.next = new ListNode(12);

            ListNode result = new OJ021_MergeTwoSortedLists().MergeTwoLists(l1, l2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(8, result.next.next.next.val);
            Assert.AreEqual(12, result.next.next.next.next.val);
            Assert.AreEqual(12, result.next.next.next.next.next.val);
            Assert.AreEqual(14, result.next.next.next.next.next.next.val);
            Assert.AreEqual(15, result.next.next.next.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next.next.next.next);
        }
    }
}
