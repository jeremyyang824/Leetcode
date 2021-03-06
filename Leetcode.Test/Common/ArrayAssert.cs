﻿using System;
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

        public static void AreEqual<T>(T[,] expected, T[,] actual)
        {
            if (expected == null && actual == null)
                return;
            if (expected == null || actual == null)
                throw new AssertFailedException(string.Format("expected value is {0}, but actual value is {1}!", expected, actual));

            Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), actual.GetLength(1));

            int m = expected.GetLength(0);
            int n = expected.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    T expectedVal = expected[i, j];
                    T acutalVal = actual[i, j];
                    Assert.AreEqual(expectedVal, acutalVal);
                }
            }
        }
    }
}
