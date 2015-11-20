using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ090_SubsetsIITest
    {
        [TestMethod]
        public void OJ090_SubsetsIITest1()
        {
            IList<IList<int>> result = new OJ090_SubsetsII().SubsetsWithDup(new int[] { 1, 2, 2 });

            ArrayAssert.AreEqual(new int[] { }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 2 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 2, 2 }, result[2].ToArray());
            ArrayAssert.AreEqual(new int[] { 1 }, result[3].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2 }, result[4].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2, 2 }, result[5].ToArray());
        }
    }
}
