using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * The count-and-say sequence is the sequence of integers beginning as follows:
     * 1, 11, 21, 1211, 111221, ...
     * 1 is read off as "one 1" or 11.
     * 11 is read off as "two 1s" or 21.
     * 21 is read off as "one 2, then one 1" or 1211.
     * Given an integer n, generate the nth sequence.
     * 
     * Note: The sequence of integers will be represented as a string.
     */
    public class OJ038_CountAndSay
    {
        public string CountAndSay(int n)
        {
            if (n < 1)
                return string.Empty;

            string say = "1";
            for (int i = 1; i < n; i++)
            {
                say = this.countAndSay(say);
            }
            return say;
        }

        private string countAndSay(string say)
        {
            char[] arr = say.ToCharArray();
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int c = 1; c < arr.Length; c++)
            {
                if (arr[c] == arr[c - 1])
                    count++;
                else
                {
                    sb.Append(count).Append(arr[c - 1]);
                    count = 1;
                }
            }
            sb.Append(count).Append(arr[arr.Length - 1]);
            return sb.ToString();
        }
    }
}
