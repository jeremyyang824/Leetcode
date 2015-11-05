using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a non-negative number represented as an array of digits, plus one to the number.
     * The digits are stored such that the most significant digit is at the head of the list.
     */
    public class OJ066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            int carry = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                carry = sum / 10;
                digits[i] = sum % 10;

                if (carry == 0)
                    break;
            }

            if (carry == 1)
            {
                int[] newDigits = new int[len + 1];
                newDigits[0] = 1;
                Array.Copy(digits, 0, newDigits, 1, len);
                return newDigits;
            }

            return digits;
        }
    }
}
