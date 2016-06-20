using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string s and a dictionary of words dict, determine if s can be segmented into a space-separated sequence of one or more dictionary words.
     * 
     * For example, given
     * s = "leetcode",
     * dict = ["leet", "code"].
     * Return true because "leetcode" can be segmented as "leet code".
     */
    public class OJ139_WordBreak
    {
        public bool WordBreak_tle(string s, HashSet<string> wordDict)
        {
            if (s == "")
                return true;

            int llen = 0,
                flen = s.Length;
            while (++llen <= flen)
            {
                string left = s.Substring(0, llen);
                if (!wordDict.Contains(left))
                    continue;

                string right = s.Substring(llen, flen - llen);
                bool rightContain = WordBreak_tle(right, wordDict);
                if (rightContain)
                    return true;
                else
                    continue;
            }
            return false;
        }

        /*
         * 改为DP算法，二维数组表示：
         * 当s长度为i的情况下，能否wordbreak
         */
        public bool WordBreak(string s, HashSet<string> wordDict)
        {
            int len = s.Length;
            bool[] arr = new bool[len + 1];
            arr[0] = true;

            for (int i = 1; i <= len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        arr[i] = true;  //在字符串长度为i的前提下，以j作为划分点，可以满足条件
                        break;
                    }
                }
            }
            return arr[len];
        }
    }
}
