using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ009_PalindromeNumberTest
    {
        [TestMethod]
        public void OJ009_PalindromeNumberTest1()
        {
            bool result = new OJ009_PalindromeNumber().IsPalindrome(-1);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ009_PalindromeNumberTest2()
        {
            bool result = new OJ009_PalindromeNumber().IsPalindrome(122);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ009_PalindromeNumberTest3()
        {
            bool result = new OJ009_PalindromeNumber().IsPalindrome(22);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ009_PalindromeNumberTest4()
        {
            bool result = new OJ009_PalindromeNumber().IsPalindrome(232);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ009_PalindromeNumberTest5()
        {
            bool result = new OJ009_PalindromeNumber().IsPalindrome(2332);
            Assert.AreEqual(true, result);
        }
    }
}
