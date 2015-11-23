using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ092_ReverseLinkedListIITest
    {
        [TestMethod]
        public void OJ092_ReverseLinkedListIITest1()
        {
            ListNode ln = new ListNode(1);
            ln.Next(2).Next(3).Next(4).Next(5);
            ListNode result = new OJ092_ReverseLinkedListII().ReverseBetween(ln, 2, 4);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(4, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(5, result.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next);
        }

        [TestMethod]
        public void OJ092_ReverseLinkedListIITest2()
        {
            ListNode ln = new ListNode(5);
            ListNode result = new OJ092_ReverseLinkedListII().ReverseBetween(ln, 1, 1);

            Assert.AreEqual(5, result.val);
            Assert.AreEqual(null, result.next);
        }
    }
}
