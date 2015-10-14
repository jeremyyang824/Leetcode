using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two numbers represented as strings, return multiplication of the numbers as a string.
     * Note: The numbers can be arbitrarily large and are non-negative.
     */
    public class OJ043_MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int l1 = num1.Length;
            int l2 = num2.Length;
            int[] result = new int[l1 + l2];

            for (int i = 0; i < l1; i++)
            {
                int carry = 0;
                int a = num1[l1 - i - 1] - '0';
                for (int j = 0; j < l2; j++)
                {
                    int b = num2[l2 - j - 1] - '0';
                    int sum = a * b + carry + result[i + j];

                    result[i + j] = sum % 10;
                    carry = sum / 10;
                }

                if (carry > 0)
                    result[i + l2] = carry;
            }

            int k = result.Length - 1;
            while (k >= 0 && result[k] == 0)
                k--;
            if (k < 0)
                return "0";

            StringBuilder sb = new StringBuilder();
            for (; k >= 0; k--)
                sb.Append(result[k].ToString());
            return sb.ToString();
        }
    }
}
