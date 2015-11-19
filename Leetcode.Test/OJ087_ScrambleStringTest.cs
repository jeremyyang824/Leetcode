using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ087_ScrambleStringTest
    {
        [TestMethod]
        public void OJ087_ScrambleStringTest1()
        {
            bool result = new OJ087_ScrambleString().IsScramble("great", "rgeat");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ087_ScrambleStringTest2()
        {
            bool result = new OJ087_ScrambleString().IsScramble("great", "rgtae");
            Assert.AreEqual(true, result);
        }
    }
}
