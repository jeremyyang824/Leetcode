using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ057_InsertIntervalTest
    {
        [TestMethod]
        public void OJ057_InsertIntervalTest1()
        {
            IList<Interval> list = new List<Interval> { 
                new Interval(1, 3),
                new Interval(6, 9),
            };
            IList<Interval> result = new OJ057_InsertInterval().Insert(list, new Interval(2, 5));
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(new Interval(1, 5), result[0]);
            Assert.AreEqual(new Interval(6, 9), result[1]);
        }

        [TestMethod]
        public void OJ057_InsertIntervalTest2()
        {
            IList<Interval> list = new List<Interval> { 
                new Interval(1, 2),
                new Interval(3, 5),
                new Interval(6, 7),
                new Interval(8, 10),
                new Interval(12, 16),
            };
            IList<Interval> result = new OJ057_InsertInterval().Insert(list, new Interval(4, 9));
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(new Interval(1, 2), result[0]);
            Assert.AreEqual(new Interval(3, 10), result[1]);
            Assert.AreEqual(new Interval(12, 16), result[2]);
        }

        [TestMethod]
        public void OJ057_InsertIntervalTest3()
        {
            IList<Interval> list = new List<Interval> { 
                new Interval(1, 5)
            };
            IList<Interval> result = new OJ057_InsertInterval().Insert(list, new Interval(0, 0));
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(new Interval(0, 0), result[0]);
            Assert.AreEqual(new Interval(1, 5), result[1]);
        }
    }
}
