using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ026_RemoveDuplicatesFromSortedArrayTest
    {
        [TestMethod]
        public void OJ026_RemoveDuplicatesFromSortedArrayTest1()
        {
            int[] arr = new int[] { 1, 1, 2 };
            int result = new OJ026_RemoveDuplicatesFromSortedArray().RemoveDuplicates(arr);
            Assert.AreEqual(2, result);
            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(2, arr[1]);
        }
    }
}
