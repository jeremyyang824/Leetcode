using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.
     * 
     * For example,
     * Given:
     * s1 = "aabcc",
     * s2 = "dbbca",
     * 
     * When s3 = "aadbbcbcac", return true.
     * When s3 = "aadbbbaccc", return false.
     */
    public class OJ097_InterleavingString
    {
        /*
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            int len3 = s3.Length;

            if (len1 + len2 != len3)
                return false;

            return isInterleave(s1, 0, s2, 0, s3, 0);
        }

        private bool isInterleave(string s1, int i1, string s2, int i2, string s3, int i3)
        {
            if (i1 == s1.Length && i2 == s2.Length && i3 == s3.Length)
                return true;

            if (i1 < s1.Length && s1[i1] == s3[i3])
            {
                if (isInterleave(s1, i1 + 1, s2, i2, s3, i3 + 1))
                    return true;
            }

            if (i2 < s2.Length && s2[i2] == s3[i3])
            {
                if (isInterleave(s1, i1, s2, i2 + 1, s3, i3 + 1))
                    return true;
            }

            return false;
        }
        */

        /*
         * 动态规划
         */
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            int len3 = s3.Length;

            if (len1 + len2 != len3)
                return false;

            bool[,] dp = new bool[len1 + 1, len2 + 1];
            dp[0, 0] = true;    //空匹配

            for (int i = 1; i <= len1; i++)
            {
                if (s1[i - 1] == s3[i - 1])
                    dp[i, 0] = true;
                else
                    break;
            }
            for (int j = 1; j <= len2; j++)
            {
                if (s2[j - 1] == s3[j - 1])
                    dp[0, j] = true;
                else
                    break;
            }

            for (int i = 1; i <= len1; i++)
            {
                for (int j = 1; j <= len2; j++)
                {
                    int k = i + j;
                    if (s1[i - 1] == s3[k - 1]) //取s1的i
                        dp[i, j] = dp[i - 1, j] || dp[i, j];    //注：dp[i,j]可能由不同路径匹配上，如果已经是true则不需再覆盖，因此要“||”
                    if (s2[j - 1] == s3[k - 1]) //取s2的j
                        dp[i, j] = dp[i, j - 1] || dp[i, j];
                }
            }

            return dp[len1, len2];
        }
    }
}
