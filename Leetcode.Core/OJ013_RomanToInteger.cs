using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    public class OJ013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            char[] symbol = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] val = { 1, 5, 10, 50, 100, 500, 1000 };
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < symbol.Length; i++)
                map.Add(symbol[i], val[i]);

            int len = s.Length;
            int res = 0;

            res += map[s[0]];
            for (int i = 1; i < len; i++)
            {
                int cur = map[s[i]];
                int pre = map[s[i - 1]];
                if (cur <= pre)
                {
                    res += cur;
                }
                else
                {
                    res = res + cur - 2 * pre;
                }
            }
            return res;
        }
    }
}
