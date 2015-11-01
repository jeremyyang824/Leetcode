using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
     * If the last word does not exist, return 0.
     * Note: A word is defined as a character sequence consists of non-space characters only.
     * 
     * For example, 
     * Given s = "Hello World",
     * return 5.
     */
    public class OJ058_LengthOfLastWord
    {
        /*
         * 从后遍历单词，遇到空格退出
         */
        public int LengthOfLastWord(string s)
        {
            if (s == null || s == string.Empty)
                return 0;

            int len = s.Length;
            while (len > 0 && s[len - 1] == ' ')
                len--;

            int sum = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    sum++;
                else
                    break;
            }
            return sum;
        }
    }
}
