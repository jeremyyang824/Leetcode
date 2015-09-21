using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ005_LongestPalindromicSubstringTest
    {
        [TestMethod]
        public void OJ005_LongestPalindromicSubstringTest1()
        {
            string result = new OJ005_LongestPalindromicSubstring().LongestPalindrome("caba");
            Assert.AreEqual("aba", result);
        }

        [TestMethod]
        public void OJ005_LongestPalindromicSubstringTest2()
        {
            string result = new OJ005_LongestPalindromicSubstring().LongestPalindrome("abacdfgdcaba");
            Assert.AreEqual("aba", result);
        }
    }
}
