using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ080_RemoveDuplicatesfromSortedArrayIITest
    {
        [TestMethod]
        public void OJ080_RemoveDuplicatesfromSortedArrayIITest1()
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 3 };
            int result = new OJ080_RemoveDuplicatesfromSortedArrayII().RemoveDuplicates(arr);

            Assert.AreEqual(5, result);
            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(1, arr[1]);
            Assert.AreEqual(2, arr[2]);
            Assert.AreEqual(2, arr[3]);
            Assert.AreEqual(3, arr[4]);
        }

        [TestMethod]
        public void OJ080_RemoveDuplicatesfromSortedArrayIITest2()
        {
            int[] arr = new int[] { 1 };
            int result = new OJ080_RemoveDuplicatesfromSortedArrayII().RemoveDuplicates(arr);

            Assert.AreEqual(1, result);
            Assert.AreEqual(1, arr[0]);;
        }
    }
}
