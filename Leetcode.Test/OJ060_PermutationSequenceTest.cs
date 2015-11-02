using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ060_PermutationSequenceTest
    {
        [TestMethod]
        public void OJ060_PermutationSequenceTest1()
        {
            string result1 = new OJ060_PermutationSequence().GetPermutation(3, 1);
            Assert.AreEqual("123", result1);

            string result2 = new OJ060_PermutationSequence().GetPermutation(3, 2);
            Assert.AreEqual("132", result2);

            string result3 = new OJ060_PermutationSequence().GetPermutation(3, 3);
            Assert.AreEqual("213", result3);

            string result4 = new OJ060_PermutationSequence().GetPermutation(3, 4);
            Assert.AreEqual("231", result4);

            string result5 = new OJ060_PermutationSequence().GetPermutation(3, 5);
            Assert.AreEqual("312", result5);

            string result6 = new OJ060_PermutationSequence().GetPermutation(3, 6);
            Assert.AreEqual("321", result6);
        }
    }
}
