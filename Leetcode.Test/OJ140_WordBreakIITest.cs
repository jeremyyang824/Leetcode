using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ140_WordBreakIITest
    {
        [TestMethod]
        public void OJ140_WordBreakIITest1()
        {
            IList<string> result = new OJ140_WordBreakII().WordBreak("catsanddog", new HashSet<string>
            {
                "cat", "cats", "and", "sand", "dog"
            });
            ArrayAssert.AreEqual(new string[] { "cat sand dog", "cats and dog", }, result.ToArray());
        }
    }
}
