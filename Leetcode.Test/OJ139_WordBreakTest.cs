using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ139_WordBreakTest
    {
        [TestMethod]
        public void OJ139_WordBreakTest1()
        {
            bool result = new OJ139_WordBreak().WordBreak("leetcode", new HashSet<string> { "leet", "code" });
            Assert.AreEqual(true, result);
        }
    }
}
