using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ068_TextJustificationTest
    {
        [TestMethod]
        public void OJ068_TextJustificationTest1()
        {
            IList<string> result = new OJ068_TextJustification().FullJustify(new string[] { 
                "This", "is", "an", "example", "of", "text", "justification." 
            }, 16);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("This    is    an", result[0]);
            Assert.AreEqual("example  of text", result[1]);
            Assert.AreEqual("justification.  ", result[2]);
        }
    }
}
