using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    public static class ArrayAssert
    {
        public static void AreEqual<T>(T[] expected, T[] actual)
        {
            if (expected == null && actual == null)
                return;
            if (expected == null || actual == null)
                throw new AssertFailedException(string.Format("expected value is {0}, but actual value is {1}!", expected, actual));

            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                T expectedVal = expected[i];
                T acutalVal = actual[i];
                Assert.AreEqual(expectedVal, acutalVal);
            }
        }
    }
}
