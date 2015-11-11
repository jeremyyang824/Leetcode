using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ076_MinimumWindowSubstringTest
    {
        [TestMethod]
        public void OJ076_MinimumWindowSubstringTest1()
        {
            string result = new OJ076_MinimumWindowSubstring().MinWindow("ADOBECODEBANC", "ABC");
            Assert.AreEqual("BANC", result);
        }
    }
}
