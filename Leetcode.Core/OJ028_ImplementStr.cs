using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement strStr().
     * Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
     */
    public class OJ028_ImplementStr
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length)
                        return i;

                    if (i + j == haystack.Length)
                        return -1;

                    if (haystack[i + j] != needle[j])
                        break;
                }
            }
        }

        //TODO：KMP
    }
}
