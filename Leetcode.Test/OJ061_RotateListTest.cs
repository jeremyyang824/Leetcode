using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ061_RotateListTest
    {
        [TestMethod]
        public void OJ061_RotateListTest1()
        {
            ListNode list = new ListNode(1);
            list.Next(2).Next(3).Next(4).Next(5);
            ListNode result = new OJ061_RotateList().RotateRight(list, 2);

            Assert.AreEqual(4, result.val);
            Assert.AreEqual(5, result.next.val);
            Assert.AreEqual(1, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(3, result.next.next.next.next.val);
            Assert.AreEqual(null, result.next.next.next.next.next);
        }

        [TestMethod]
        public void OJ061_RotateListTest2()
        {
            ListNode list = new ListNode(1);
            ListNode result = new OJ061_RotateList().RotateRight(list, 1);
            Assert.AreEqual(1, result.val);
        }

        [TestMethod]
        public void OJ061_RotateListTest3()
        {
            ListNode list = new ListNode(1);
            list.Next(2);
            ListNode result = new OJ061_RotateList().RotateRight(list, 0);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(null, result.next.next);
        }

        [TestMethod]
        public void OJ061_RotateListTest4()
        {
            ListNode list = new ListNode(1);
            list.Next(2);
            ListNode result = new OJ061_RotateList().RotateRight(list, 1);
            Assert.AreEqual(2, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(null, result.next.next);
        }
    }
}
