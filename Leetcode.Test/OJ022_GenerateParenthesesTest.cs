using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ022_GenerateParenthesesTest
    {
        [TestMethod]
        public void OJ022_GenerateParenthesesTest1()
        {
            string[] result = new OJ022_GenerateParentheses().GenerateParenthesis(3).ToArray();
            Array.Sort(result);

            Assert.AreEqual(5, result.Length);
            Assert.AreEqual("((()))", result[0]);
            Assert.AreEqual("(()())", result[1]);
            Assert.AreEqual("(())()", result[2]);
            Assert.AreEqual("()(())", result[3]);
            Assert.AreEqual("()()()", result[4]);
        }
    }
}
