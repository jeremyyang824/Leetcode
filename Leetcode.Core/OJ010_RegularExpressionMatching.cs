using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement regular expression matching with support for '.' and '*'.
     * 
     * '.' Matches any single character.
     * '*' Matches zero or more of the preceding element.
     * The matching should cover the entire input string (not partial).
     * 
     * The function prototype should be:
     * bool isMatch(const char *s, const char *p)
     * 
     * Some examples:
     * isMatch("aa","a") → false
     * isMatch("aa","aa") → true
     * isMatch("aaa","aa") → false
     * isMatch("aa", "a*") → true
     * isMatch("ab", "a*") → false
     * isMatch("aa", ".*") → true
     * isMatch("ab", ".*") → true
     * isMatch("aab", "c*a*b") → true
     * 
     * ca(aaaaaaaaaa)aaab(bbbbbbbbbb)bbd → ca(a*)aaab(b*)bbd
     */
    public class OJ010_RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;
            return this.isMatch(s, 0, p, 0);
        }

        private bool isMatch(string str, int strIdx, string patten, int pattenIdx)
        {
            if (strIdx == str.Length && pattenIdx == patten.Length)
                return true;

            if (pattenIdx + 1 < patten.Length && patten[pattenIdx + 1] == '*')
            {
                while (strIdx < str.Length && (patten[pattenIdx] == '.' || str[strIdx] == patten[pattenIdx]))
                {
                    if (isMatch(str, strIdx, patten, pattenIdx + 2))
                        return true;
                    strIdx++;
                }

                return isMatch(str, strIdx, patten, pattenIdx + 2);
            }
            else
            {
                if (strIdx < str.Length && pattenIdx < patten.Length && (patten[pattenIdx] == '.' || str[strIdx] == patten[pattenIdx]))
                    return this.isMatch(str, strIdx + 1, patten, pattenIdx + 1);
                return false;
            }
        }
    }
}
