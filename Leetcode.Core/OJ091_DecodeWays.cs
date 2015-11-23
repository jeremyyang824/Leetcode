using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * A message containing letters from A-Z is being encoded to numbers using the following mapping:
     * 'A' -> 1
     * 'B' -> 2
     * ...
     * 'Z' -> 26
     * Given an encoded message containing digits, determine the total number of ways to decode it.
     * 
     * For example,
     * Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).
     * The number of ways decoding "12" is 2.
     */
    public class OJ091_DecodeWays
    {
        /*
         * 相关问题：爬楼梯问题：一段楼梯共n级台阶，每次只能走一级、两级或三级台阶，问共有多少种走法？
         * 分析：
         * 首先考虑第一步的走法：第一步可以跨1级台阶，也可以跨2级和3级台阶。
         * 设S(n)表示走n级台阶的走法数量,
         * 如果第一步跨1级台阶，剩下的台阶数为n-1, 相当于S(n-1)；
         * 如果第一步跨2级台阶，剩下的台阶数为n-2，相当于S(n-2)；
         * 如果第一步跨3级台阶，剩下的台阶数为n-3，相当于S(n-3)。
         * 从而得到递推关系式：
         * S(n) = S(n-1) + S(n-2) + S(n-3)
         * 如果题目规定每次只能走1级或2级台阶，S(n)与Fibonacci数的关系为：S(n) = F(n+1)
         * 
         * 类似爬楼梯问题，但要加很多限制条件：
         * 第一：s[i-1]不能是0，如果s[i-1]是0的话，number[i]就只能等于number[i-2]
         * 第二：s[i-2]中的第一个字符不能是0，且Integer.parseInt(s.substring(i-2,i))获得的整数必须在0到26之间。
         */
        public int NumDecodings(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            char[] arr = s.ToCharArray();
            if (arr[0] == '0')
                return 0;

            int[] number = new int[arr.Length + 1];
            number[0] = 1;  //第一步可以选择不走
            number[1] = 1;
            for (int i = 2; i < number.Length; i++)
            {
                if (arr[i - 1] != '0')
                    number[i] += number[i - 1];

                if (arr[i - 2] != '0')
                {
                    int tmp = int.Parse(arr[i - 2].ToString() + arr[i - 1].ToString());
                    if (tmp > 0 && tmp <= 26)
                        number[i] += number[i - 2];
                }
            }
            return number[number.Length - 1];
        }
    }
}
