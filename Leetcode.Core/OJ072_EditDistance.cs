using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)
     * You have the following 3 operations permitted on a word:
     * a) Insert a character
     * b) Delete a character
     * c) Replace a character
     */
    public class OJ072_EditDistance
    {
        /*
         * i表示当前字符串A的下标；j表示当前字符串B的下标
         * D[i, j] 来表示A[1,...i] B[1,...j] 之间的最少编辑操作数
         * 那么D(N, M)：
         * D(i, 0) = i
         * D(0, j) = j
         * D(i, j) = Min{
         *   D(i-1, j) + 1      deletion
         *   D(i, j-1) + 1      insertion
         *   D(i-1, j-1) + 1    substitution    X(i) != Y(j)
         *   D(i-1, j-1) + 0                    X(i) == Y(j)
         * }
         */
        public int MinDistance(string word1, string word2)
        {
            int row = word1.Length + 1;
            int col = word2.Length + 1;

            int[,] map = new int[row, col];

            for (int i = 0; i < row; i++)
                map[i, 0] = i;
            for (int j = 0; j < col; j++)
                map[0, j] = j;

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                        map[i, j] = map[i - 1, j - 1];
                    else
                        map[i, j] = map[i - 1, j - 1] + 1;

                    map[i, j] = Math.Min(map[i, j], Math.Min(map[i - 1, j] + 1, map[i, j - 1] + 1));
                }
            }
            return map[row - 1, col - 1];
        }
    }
}
