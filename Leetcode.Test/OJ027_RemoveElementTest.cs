using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ027_RemoveElementTest
    {
        [TestMethod]
        public void OJ027_RemoveElementTest1()
        {
            int[] arr = new int[] { 2, 4, 5, 2, 4 };
            int result = new OJ027_RemoveElement().RemoveElement(arr, 2);
            Assert.AreEqual(3, result);
            Assert.AreEqual(4, arr[0]);
            Assert.AreEqual(5, arr[1]);
            Assert.AreEqual(4, arr[2]);
        }
    }
}
