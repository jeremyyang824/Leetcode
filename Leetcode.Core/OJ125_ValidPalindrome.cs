using System;
using System.Collections.Generic;

namespace Leetcode.Core
{
    /*
     * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
     * For example,
     * "A man, a plan, a canal: Panama" is a palindrome.
     * "race a car" is not a palindrome.
     * 
     * Note:
     * Have you consider that the string might be empty? This is a good question to ask during an interview.
     * For the purpose of this problem, we define empty string as valid palindrome.
     */
    public class OJ125_ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s == null)
                return false;
            if (s == string.Empty)
                return true;

            char[] charArr = s.ToLower().ToCharArray();
            int l = 0, r = s.Length - 1;

            while (l < r)
            {
                char cl = charArr[l];
                while ((cl < 'a' || cl > 'z') && (cl < '0' || cl > '9'))
                {
                    if (++l >= r)
                        return true;
                    cl = charArr[l];
                }

                char cr = charArr[r];
                while ((cr < 'a' || cr > 'z') && (cr < '0' || cr > '9'))
                {
                    if (--r <= l)
                        return true;
                    cr = charArr[r];
                }

                if (cl != cr)
                    return false;

                l++;
                r--;
            }
            return true;
        }
    }
}
