using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ020_ValidParenthesesTest
    {
        [TestMethod]
        public void OJ020_ValidParenthesesTest1()
        {
            bool result = new OJ020_ValidParentheses().IsValid("public void test(int val) { if(val > 0) return true; }");
            Assert.AreEqual(true, result);
        }
    }
}
