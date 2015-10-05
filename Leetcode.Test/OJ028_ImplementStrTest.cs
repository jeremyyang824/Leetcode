using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ028_ImplementStrTest
    {
        [TestMethod]
        public void OJ028_ImplementStrTest1()
        {
            int result = new OJ028_ImplementStr().StrStr("hello world!", "world");
            Assert.AreEqual(6, result);
        }
    }
}
