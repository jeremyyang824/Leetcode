using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ127_WordLadderTest
    {
        [TestMethod]
        public void OJ127_WordLadderTest1()
        {
            int result = new OJ127_WordLadder().LadderLength("hit", "cog", new System.Collections.Generic.HashSet<string>
            {
                "hot","dot","dog","lot","log"
            });
            Assert.AreEqual(5, result);
        }
    }
}
