using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ206_ReverseLinkedListTest
    {
        [TestMethod]
        public void OJ206_ReverseLinkedListTest1()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);

            ListNode result = new OJ206_ReverseLinkedList().ReverseList(l1);
            Assert.AreEqual(5, result.val);
            Assert.AreEqual(4, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(1, result.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next);
        }
    }
}
