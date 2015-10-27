using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ049_GroupAnagramsTest
    {
        [TestMethod]
        public void OJ049_GroupAnagramsTest1()
        {
            IList<IList<string>> result = new OJ049_GroupAnagrams().GroupAnagrams(new string[] { 
                "eat", "tea", "tan", "ate", "nat", "bat"
            });
            ArrayAssert.AreEqual(new string[] { "ate", "eat", "tea" }, result[0].ToArray());
            ArrayAssert.AreEqual(new string[] { "bat" }, result[1].ToArray());
            ArrayAssert.AreEqual(new string[] { "nat", "tan" }, result[2].ToArray());
        }
    }
}
