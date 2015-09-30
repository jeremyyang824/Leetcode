using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ019_RemoveNthNodeFromEndOfListTest
    {
        [TestMethod]
        public void OJ019_RemoveNthNodeFromEndOfListTest1()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);

            ListNode result = new OJ019_RemoveNthNodeFromEndOfList().RemoveNthFromEnd(l1, 2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(5, result.next.next.next.val);
        }

        [TestMethod]
        public void OJ019_RemoveNthNodeFromEndOfListTest2()
        {
            ListNode l1 = new ListNode(1);
            ListNode result = new OJ019_RemoveNthNodeFromEndOfList().RemoveNthFromEnd(l1, 1);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void OJ019_RemoveNthNodeFromEndOfListTest3()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            ListNode result = new OJ019_RemoveNthNodeFromEndOfList().RemoveNthFromEnd(l1, 2);
            Assert.AreEqual(2, result.val);
        }
    }
}
