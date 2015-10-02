using System;
using System.Linq;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ017_LetterCombinationsOfAPhoneNumberTest
    {
        [TestMethod]
        public void OJ017_LetterCombinationsOfAPhoneNumberTest1()
        {
            string[] result = new OJ017_LetterCombinationsOfAPhoneNumber().LetterCombinations("23").ToArray();
            Array.Sort(result);

            Assert.AreEqual(9, result.Length);
            Assert.AreEqual("ad", result[0]);
            Assert.AreEqual("ae", result[1]);
            Assert.AreEqual("af", result[2]);
            Assert.AreEqual("bd", result[3]);
            Assert.AreEqual("be", result[4]);
            Assert.AreEqual("bf", result[5]);
            Assert.AreEqual("cd", result[6]);
            Assert.AreEqual("ce", result[7]);
            Assert.AreEqual("cf", result[8]);
        }
    }
}
