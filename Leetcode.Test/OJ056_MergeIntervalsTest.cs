using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ056_MergeIntervalsTest
    {
        [TestMethod]
        public void OJ056_MergeIntervalsTest1()
        {
            IList<Interval> list = new List<Interval> { 
                new Interval(1, 3),
                new Interval(2, 6),
                new Interval(8, 10),
                new Interval(15, 18),
            };
            IList<Interval> result = new OJ056_MergeIntervals().Merge(list);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(new Interval(1, 6), result[0]);
            Assert.AreEqual(new Interval(8, 10), result[1]);
            Assert.AreEqual(new Interval(15, 18), result[2]);
        }
    }
}
