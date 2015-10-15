using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement wildcard pattern matching with support for '?' and '*'.
     * 
     * '?' Matches any single character.
     * '*' Matches any sequence of characters (including the empty sequence).
     * The matching should cover the entire input string (not partial).
     * 
     * The function prototype should be:
     * bool isMatch(const char *s, const char *p)
     * 
     * Some examples:
     * isMatch("aa","a") → false
     * isMatch("aa","aa") → true
     * isMatch("aaa","aa") → false
     * isMatch("aa", "*") → true
     * isMatch("aa", "a*") → true
     * isMatch("ab", "?*") → true
     * isMatch("aab", "c*a*b") → false
     */
    public class OJ044_WildcardMatching
    {
        /* Time Limit Exceeded
        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;
            return this.isMatch(s, 0, p, 0);
        }

        private bool isMatch(string str, int strIdx, string patten, int pattenIdx)
        {
            int slen = str.Length;
            int plen = patten.Length;

            if (strIdx == slen && pattenIdx == plen)
                return true;

            if (pattenIdx < plen && patten[pattenIdx] == '*')
            {
                while (pattenIdx < plen && patten[pattenIdx] == '*')
                    pattenIdx++;

                while (strIdx < slen)
                {
                    if (isMatch(str, strIdx, patten, pattenIdx))
                        return true;
                    strIdx++;
                }

                return isMatch(str, strIdx, patten, pattenIdx);
            }
            else
            {
                if (strIdx < slen && pattenIdx < plen && (patten[pattenIdx] == '?' || str[strIdx] == patten[pattenIdx]))
                    return this.isMatch(str, strIdx + 1, patten, pattenIdx + 1);
                return false;
            }
        }
        */

        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;

            int si = 0;
            int pi = 0;

            int sStar = -1;
            int pStar = -1;
            while (si < s.Length)
            {
                if (pi < p.Length && (p[pi] == '?' || s[si] == p[pi]))
                {
                    si++;
                    pi++;
                }
                else if (pi < p.Length && p[pi] == '*')
                {
                    sStar = si;
                    pStar = pi;
                    pi++;
                }
                else if (pStar != -1)
                {
                    si = ++sStar;
                    pi = pStar + 1;
                }
                else
                    return false;
            }

            while (pi < p.Length && p[pi] == '*')
                pi++;
            return pi == p.Length;
        }
    }
}
