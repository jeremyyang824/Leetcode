using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ128_LongestConsecutiveSequenceTest
    {
        [TestMethod]
        public void OJ128_LongestConsecutiveSequenceTest1()
        {
            int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
            int count = new OJ128_LongestConsecutiveSequence().LongestConsecutive(nums);
            Assert.AreEqual(4, count);
        }
    }
}
