using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ058_LengthOfLastWordTest
    {
        [TestMethod]
        public void OJ058_LengthOfLastWordTest1()
        {
            int result = new OJ058_LengthOfLastWord().LengthOfLastWord("Hello World");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void OJ058_LengthOfLastWordTest2()
        {
            int result = new OJ058_LengthOfLastWord().LengthOfLastWord("  ");
            Assert.AreEqual(0, result);
        }
    }
}
