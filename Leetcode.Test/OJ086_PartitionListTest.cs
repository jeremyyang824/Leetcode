using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ086_PartitionListTest
    {
        [TestMethod]
        public void OJ086_PartitionListTest1()
        {
            ListNode ln = new ListNode(1);
            ln.Next(4).Next(3).Next(2).Next(5).Next(2);
            ListNode result = new OJ086_PartitionList().Partition(ln, 3);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(4, result.next.next.next.val);
            Assert.AreEqual(3, result.next.next.next.next.val);
            Assert.AreEqual(5, result.next.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next.next);
        }
    }
}
