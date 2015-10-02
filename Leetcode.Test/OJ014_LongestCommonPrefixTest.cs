using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ014_LongestCommonPrefixTest
    {
        [TestMethod]
        public void OJ014_LongestCommonPrefixTest1()
        {
            string result = new OJ014_LongestCommonPrefix().LongestCommonPrefix(new string[]{
                "present", "prefer", "previous", "press", "pretty"
            });
            Assert.AreEqual("pre", result);
        }
    }
}
