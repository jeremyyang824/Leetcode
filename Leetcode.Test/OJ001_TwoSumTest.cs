using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ001_TwoSumTest
    {
        [TestMethod]
        public void OJ001_TwoSumTest1()
        {
            int[] num = new int[] { 2, 7, 11, 15 };
            int[] result = new OJ001_TwoSum().TwoSum(num, 9);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void OJ001_TwoSumTest2()
        {
            int[] num = new int[] { 7, 2, 11, 15 };
            int[] result = new OJ001_TwoSum().TwoSum(num, 9);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void OJ001_TwoSumTest3()
        {
            int[] num = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            int[] result = new OJ001_TwoSum().TwoSum(num, 542);
            Assert.AreEqual(29, result[0]);
            Assert.AreEqual(46, result[1]);
        }
    }
}
