using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ083_RemoveDuplicatesFromSortedListTest
    {
        [TestMethod]
        public void OJ083_RemoveDuplicatesFromSortedListTest1()
        {
            ListNode ln = new ListNode(1);
            ln.Next(1).Next(2);
            ListNode result = new OJ083_RemoveDuplicatesFromSortedList().DeleteDuplicates(ln);
            Assert.AreEqual(1, ln.val);
            Assert.AreEqual(2, ln.next.val);
            Assert.AreEqual(null, ln.next.next);
        }

        [TestMethod]
        public void OJ083_RemoveDuplicatesFromSortedListTest2()
        {
            ListNode ln = new ListNode(1);
            ln.Next(1).Next(2).Next(3).Next(3);
            ListNode result = new OJ083_RemoveDuplicatesFromSortedList().DeleteDuplicates(ln);
            Assert.AreEqual(1, ln.val);
            Assert.AreEqual(2, ln.next.val);
            Assert.AreEqual(3, ln.next.next.val);
            Assert.AreEqual(null, ln.next.next.next);
        }

        [TestMethod]
        public void OJ083_RemoveDuplicatesFromSortedListTest3()
        {
            ListNode ln = new ListNode(1);
            ln.Next(1).Next(1);
            ListNode result = new OJ083_RemoveDuplicatesFromSortedList().DeleteDuplicates(ln);
            Assert.AreEqual(1, ln.val);
            Assert.AreEqual(null, ln.next);
        }
    }
}
