using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ125_ValidPalindromeTest
    {
        [TestMethod]
        public void OJ125_ValidPalindromeTest1()
        {
            bool result = new OJ125_ValidPalindrome().IsPalindrome("A man, a plan, a canal: Panama");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ125_ValidPalindromeTest2()
        {
            bool result = new OJ125_ValidPalindrome().IsPalindrome("race a car");
            Assert.AreEqual(false, result);
        }
    }
}
