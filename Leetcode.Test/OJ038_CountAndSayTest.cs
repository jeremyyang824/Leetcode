using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ038_CountAndSayTest
    {
        [TestMethod]
        public void OJ038_CountAndSay1()
        {
            string result = new OJ038_CountAndSay().CountAndSay(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void OJ038_CountAndSay2()
        {
            string result = new OJ038_CountAndSay().CountAndSay(3);
            Assert.AreEqual("21", result);
        }

        [TestMethod]
        public void OJ038_CountAndSay3()
        {
            string result = new OJ038_CountAndSay().CountAndSay(5);
            Assert.AreEqual("111221", result);
        }
    }
}
