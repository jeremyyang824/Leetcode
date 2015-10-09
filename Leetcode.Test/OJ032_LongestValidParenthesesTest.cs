using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ032_LongestValidParenthesesTest
    {
        [TestMethod]
        public void OJ032_LongestValidParenthesesTest1()
        {
            int result = new OJ032_LongestValidParentheses().LongestValidParentheses("(()");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OJ032_LongestValidParenthesesTest2()
        {
            int result = new OJ032_LongestValidParentheses().LongestValidParentheses(")()())");
            Assert.AreEqual(4, result);
        }
    }
}
