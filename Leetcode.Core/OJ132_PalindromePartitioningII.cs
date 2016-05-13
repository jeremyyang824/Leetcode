using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /**
     * Given a string s, partition s such that every substring of the partition is a palindrome.
     * Return the minimum cuts needed for a palindrome partitioning of s.
     * 
     * For example, given s = "aab",
     * Return 1 since the palindrome partitioning ["aa","b"] could be produced using 1 cut.
     * 
     */
    public class OJ132_PalindromePartitioningII
    {
        /*
         * count[i] = min{1 + count[j+1]}, dp[i,j]=1 (i<=j<len)
         * 
         * 从i开始的字符串的最小划分为：如果从位置i到位置j的子串是回文串（1 cut），
         * 则从i开始的划分可以通过将i到j的子串看作划分的一部分，
         * 然后加上从j+1位置开始的子串最小划分，并选择可能情况中的最小值即为从i开始的最小划分。
         */
        public int MinCut(string s)
        {
            if (s == null || s.Length < 1)
                return 0;

            int len = s.Length;
            bool[,] isPalTable = new bool[len, len];
            this.buildPalTable(isPalTable, s, len);

            int[] count = new int[len + 1];
            for (int i = len - 1; i >= 0; i--)
            {
                count[i] = int.MaxValue;
                for (int j = i; j < len; j++)
                {
                    if (isPalTable[i, j])
                    {
                        count[i] = Math.Min(1 + count[j + 1], count[i]);
                    }
                }
            }
            return count[0] - 1;
        }

        public void buildPalTable(bool[,] isPalTable, string s, int len)
        {
            for (int i = 0; i < len; i++)
            {
                isPalTable[i, i] = true;
            }

            //按间距从小到大计算
            for (int dis = 1; dis <= len; dis++)
            {
                for (int i = 0, j = i + dis; j < len; i++, j++)
                {
                    bool innerPal = true;
                    if (i + 1 < j - 1)
                        innerPal = isPalTable[i + 1, j - 1];

                    //由于间距是从小到大计算，因此内部字符串一定已经计算过
                    isPalTable[i, j] = innerPal && (s[i] == s[j]);
                }
            }
        }
    }
}
