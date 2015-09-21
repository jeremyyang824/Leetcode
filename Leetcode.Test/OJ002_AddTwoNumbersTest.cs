using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ002_AddTwoNumbersTest
    {
        [TestMethod]
        public void OJ002_AddTwoNumbersTest1()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode l3 = new ListNode(7);
            l3.next = new ListNode(0);
            l3.next.next = new ListNode(8);

            ListNode result = new OJ002_AddTwoNumbers().AddTwoNumbers(l1, l2);
            Assert.AreEqual(l3.val, result.val);
            Assert.AreEqual(l3.next.val, result.next.val);
            Assert.AreEqual(l3.next.next.val, result.next.next.val);
            Assert.IsNull(result.next.next.next);
        }

        [TestMethod]
        public void OJ002_AddTwoNumbersTest2()
        {
            ListNode l1 = new ListNode(1);

            ListNode l2 = new ListNode(9);
            l2.next = new ListNode(9);

            ListNode l3 = new ListNode(0);
            l3.next = new ListNode(0);
            l3.next.next = new ListNode(1);

            ListNode result = new OJ002_AddTwoNumbers().AddTwoNumbers(l1, l2);
            Assert.AreEqual(l3.val, result.val);
            Assert.AreEqual(l3.next.val, result.next.val);
            Assert.AreEqual(l3.next.next.val, result.next.next.val);
            Assert.IsNull(result.next.next.next);
        }
    }
}
