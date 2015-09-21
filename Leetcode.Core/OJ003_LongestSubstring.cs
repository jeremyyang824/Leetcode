using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string, find the length of the longest substring without repeating characters. 
     * For example, the longest substring without repeating letters for "abcabcbb" is "abc", 
     * which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
     * 
     * 01234567
     * abcdcedf -> cedf
     */
    public class OJ003_LongestSubstring
    {
        /*
         Solution:
         * How can we can look up if a character had existed in the substring instantaneously? 
         * The answer is using a simple table to store the characters that have appeared. 
         * Make sure you communicate with your interviewer if the string can have characters other than ‘a’-‘z’. (ie, Digits? Upper case letter? Does it contain ASCII characters only? Or even unicode character sets?)
         * 
         * As you traverse through the string, update by using its ASCII value as index to the table. 
         * If the string only contains ‘a’-‘z’, you could save space by using a table of size 26 only. 
         * Assuming c is the character, then c-‘a’ will give you a value of 0-25 which can be used to index the table directly.
         * 
         * The next question is to ask yourself what happens when you found a repeated character? 
         * For example, if the string is “abcdcedf”, what happens when you reach the second appearance of ‘c’?
         * 
         * When you have found a repeated character (let’s say at index j), it means that the current substring (excluding the repeated character of course) is a potential maximum, so update the maximum if necessary. 
         * It also means that the repeated character must have appeared before at an index i, where i is less than j.
         * 
         * Since you know that all substrings that start before or at index i would be less than your current maximum, 
         * you can safely start to look for the next substring with head which starts exactly at index i+1.
         * 
         * Therefore, you would need two indices to record the head and the tail of the current substring. 
         * Since i and j both traverse at most n steps, the worst case would be 2n steps, which the run time complexity must be O(n).
         */
        public int LengthOfLongestSubstring(string s)
        {
            char[] arr = s.ToCharArray();

            Dictionary<char, int> exists = new Dictionary<char, int>();
            int start = 0, max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                char c = arr[i];
                if (exists.ContainsKey(c) && exists[c] >= start)
                {
                    start = exists[c] + 1;
                }

                if ((i - start + 1) > max)
                    max = i - start + 1;

                exists[c] = i;
            }
            return max;
        }
    }
}
