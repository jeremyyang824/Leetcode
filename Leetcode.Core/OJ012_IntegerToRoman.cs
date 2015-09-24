using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an integer, convert it to a roman numeral.
     * Input is guaranteed to be within the range from 1 to 3999.
     * 
     * 1~9: {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
     * 10~90: {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
     * 100~900: {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
     * 1000~3000: {"M", "MM", "MMM"}.
     */
    public class OJ012_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    result.Append(numerals[i]);
                }
            }
            return result.ToString();
        }
    }
}
