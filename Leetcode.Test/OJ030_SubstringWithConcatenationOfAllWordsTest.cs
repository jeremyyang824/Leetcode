using System;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ030_SubstringWithConcatenationOfAllWordsTest
    {
        [TestMethod]
        public void OJ030_SubstringWithConcatenationOfAllWordsTest1()
        {
            int[] result = new OJ030_SubstringWithConcatenationOfAllWords()
                .FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" })
                .ToArray();
            Array.Sort(result);
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(9, result[1]);
        }

        [TestMethod]
        public void OJ030_SubstringWithConcatenationOfAllWordsTest2()
        {
            int[] result = new OJ030_SubstringWithConcatenationOfAllWords()
                .FindSubstring("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" })
                .ToArray();
            //Array.Sort(result);
            //Assert.AreEqual(2, result.Length);
            //Assert.AreEqual(0, result[0]);
            //Assert.AreEqual(9, result[1]);
        }
    }
}
