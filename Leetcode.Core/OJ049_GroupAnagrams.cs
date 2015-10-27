using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of strings, group anagrams together.
     * For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
     * Return:
     * [
     *   ["ate", "eat","tea"],
     *   ["nat","tan"],
     *   ["bat"]
     * ]
     * 
     * Note:
     * For the return value, each inner list's elements must follow the lexicographic order.
     * All inputs will be in lower-case.
     */
    public class OJ049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Array.Sort(strs, 0, strs.Length);

            Dictionary<string, IList<string>> maps = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string str = strs[i];
                string strCode = this.getStrCode(str);
                if (!maps.ContainsKey(strCode))
                {
                    maps.Add(strCode, new List<string>());
                }
                maps[strCode].Add(str);
            }
            return maps.Values.ToList();
        }

        private string getStrCode(string str)
        {
            char[] chars = str.ToArray();
            Array.Sort(chars, 0, chars.Length);
            return new string(chars);
        }
    }
}
