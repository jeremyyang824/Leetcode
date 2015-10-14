using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ044_WildcardMatchingTest
    {
        [TestMethod]
        public void OJ044_WildcardMatchingTest1()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aa", "a");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest2()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("abc", "a?c");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest3()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aa", "aa");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest4()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aaa", "aa");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest5()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aa", "a*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest6()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("ab", "a*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest7()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("b", "?*?");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest8()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("ab", "?*");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest9()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aab", "c*a*b");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ044_WildcardMatchingTest10()
        {
            bool result = new OJ044_WildcardMatching().IsMatch("aa", "*");
            Assert.AreEqual(true, result);
        }
    }
}
