using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string S, find the longest palindromic substring in S. 
     * You may assume that the maximum length of S is 1000, and there exists one unique longest palindromic substring.
     */
    public class OJ005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0)
                return "";

            string longest = "";
            for (int i = 0; i < n; i++)
            {
                string s1 = this.checkString(s, i, i);
                if (s1.Length > longest.Length)
                    longest = s1;

                string s2 = this.checkString(s, i, i + 1);
                if (s2.Length > longest.Length)
                    longest = s2;
            }
            return longest;
        }

        private string checkString(string s, int i, int j)
        {
            int n = s.Length;
            while (i >= 0 && j < n && s[i] == s[j])
            {
                i--;
                j++;
            }
            return s.Substring(i + 1, j - i - 1);
        }
    }
}
