using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string S and a string T, count the number of distinct subsequences of T in S.
     * A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of 
     * the characters without disturbing the relative positions of the remaining characters. (ie, "ACE" is a subsequence of "ABCDE" while "AEC" is not).
     * Here is an example:
     * S = "rabbbit", T = "rabbit"
     * Return 3.
     */
    public class OJ115_DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            if (s == null || t == null)
                return 0;

            int[,] map = new int[s.Length + 1, t.Length + 1];

            //任意一个字符串变换成一个空串都只有一种变换方法  
            for (int i = 0; i < s.Length; i++)
                map[i, 0] = 1;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= t.Length; j++)
                {
                    if (s[i - 1] == t[j - 1])
                        map[i, j] += map[i - 1, j] + map[i - 1, j - 1]; //如果当前S[i]==T[j]，那么当前这个字母即可以抛弃也可以保留
                    else
                        map[i, j] += map[i - 1, j]; //如果当前字符不等，那么就只能抛弃当前这个字符
                }
            }
            return map[s.Length, t.Length];
        }
    }
}
