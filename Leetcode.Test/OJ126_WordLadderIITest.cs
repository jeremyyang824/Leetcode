using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ126_WordLadderIITest
    {
        [TestMethod]
        public void OJ126_WordLadderIITest1()
        {
            List<List<String>> result = new OJ126_WordLadderII().findLadders("hit", "cog", new System.Collections.Generic.HashSet<string>
            {
                "hot","dot","dog","lot","log"
            });
            Assert.AreEqual(2, result.Count);
            ArrayAssert.AreEqual(new string[] { "hit", "hot", "dot", "dog", "cog" }, result[0].ToArray());
            ArrayAssert.AreEqual(new string[] { "hit", "hot", "lot", "log", "cog" }, result[1].ToArray());
        }
    }
}
