using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
     * For example,
     * Given n = 3,
     * You should return the following matrix:
     * [
     *  [ 1, 2, 3 ],
     *  [ 8, 9, 4 ],
     *  [ 7, 6, 5 ]
     * ]
     */
    public class OJ059_SpiralMatrixII
    {
        public int[,] GenerateMatrix(int n)
        {
            int[,] result = new int[n, n];
            int start = 0, end = n - 1;
            int num = 1;

            while (start < end)
            {
                for (int j = start; j < end; j++)
                {
                    result[start, j] = num;
                    num++;
                }

                for (int i = start; i < end; i++)
                {
                    result[i, end] = num;
                    num++;
                }

                for (int j = end; j > start; j--)
                {
                    result[end, j] = num;
                    num++;
                }

                for (int i = end; i > start; i--)
                {
                    result[i, start] = num;
                    num++;
                }

                start++;
                end--;
            }

            if (start == end)
            {
                result[start, start] = num;
            }
            return result;
        }
    }
}
