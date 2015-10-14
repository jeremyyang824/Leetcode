using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ010_RegularExpressionMatchingTest
    {
        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest1()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aa", "a");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest2()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("abc", "a.c");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest3()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aa", "aa");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest4()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aaa", "aa");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest5()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aa", "a*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest6()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("ab", "a*");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest7()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aa", ".*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest8()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("ab", ".*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest9()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("aab", "c*a*b");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest10()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("caaaaaaaaaaaaaabbbbbbbbbbbbbd", "caa*aaabb*bbd");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ010_RegularExpressionMatchingTest11()
        {
            bool result = new OJ010_RegularExpressionMatching().IsMatch("bbbba", ".*a*a");
            Assert.AreEqual(true, result);
        }
    }
}
