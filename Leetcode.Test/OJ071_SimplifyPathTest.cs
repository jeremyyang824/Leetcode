using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ071_SimplifyPathTest
    {
        [TestMethod]
        public void OJ071_SimplifyPathTest1()
        {
            string result = new OJ071_SimplifyPath().SimplifyPath("/home/");
            Assert.AreEqual("/home", result);
        }

        [TestMethod]
        public void OJ071_SimplifyPathTest2()
        {
            string result = new OJ071_SimplifyPath().SimplifyPath("/a/./b/../../c/");
            Assert.AreEqual("/c", result);
        }

        [TestMethod]
        public void OJ071_SimplifyPathTest3()
        {
            string result = new OJ071_SimplifyPath().SimplifyPath("/../");
            Assert.AreEqual("/", result);
        }
        [TestMethod]
        public void OJ071_SimplifyPathTest4()
        {
            string result = new OJ071_SimplifyPath().SimplifyPath("/home//foo/");
            Assert.AreEqual("/home/foo", result);
        }

    }
}
