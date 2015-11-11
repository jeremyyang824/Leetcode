using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
     * For example,
     * S = "ADOBECODEBANC"
     * T = "ABC"
     * Minimum window is "BANC".
     * 
     * Note:
     * If there is no such window in S that covers all characters in T, return the empty string "".
     * If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
     */
    public class OJ076_MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length < 1 || t.Length < 1)
                return "";

            int[] count1 = new int[256];
            int[] count2 = new int[256];
            for (int i = 0; i < t.Length; i++)
            {
                count1[t[i]]++;
                count2[t[i]]++;
            }

            int count = t.Length;
            int start = 0;
            int minSize = int.MaxValue;
            int minStart = 0;
            for (int end = 0; end < s.Length; end++)
            {
                if (count2[s[end]] > 0)
                {
                    count1[s[end]]--;
                    if (count1[s[end]] >= 0)
                        count--;
                }

                if (count == 0)
                {
                    while (true)
                    {
                        if (count2[s[start]] > 0)
                        {
                            if (count1[s[start]] < 0)
                                count1[s[start]]++;
                            else
                                break;
                        }
                        start++;
                    }

                    if (minSize > end - start + 1)
                    {
                        minSize = end - start + 1;
                        minStart = start;
                    }
                }
            }

            if (minSize == int.MaxValue)
                return "";

            return s.Substring(minStart, minSize);
        }
    }
}
