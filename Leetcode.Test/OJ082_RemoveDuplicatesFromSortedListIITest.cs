using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ082_RemoveDuplicatesFromSortedListIITest
    {
        [TestMethod]
        public void OJ082_RemoveDuplicatesFromSortedListIITest1()
        {
            ListNode ln = new ListNode(1);
            ln.Next(2).Next(3).Next(3).Next(4).Next(4).Next(5);
            ListNode result = new OJ082_RemoveDuplicatesFromSortedListII().DeleteDuplicates(ln);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(5, result.next.next.val);
            Assert.AreEqual(null, result.next.next.next);
        }

        [TestMethod]
        public void OJ082_RemoveDuplicatesFromSortedListIITest2()
        {
            ListNode ln = new ListNode(1);
            ln.Next(1).Next(1).Next(2).Next(3);
            ListNode result = new OJ082_RemoveDuplicatesFromSortedListII().DeleteDuplicates(ln);
            Assert.AreEqual(2, result.val);
            Assert.AreEqual(3, result.next.val);
            Assert.AreEqual(null, result.next.next);
        }
    }
}
