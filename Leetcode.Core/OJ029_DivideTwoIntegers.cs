using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Divide two integers without using multiplication, division and mod operator.
     * If it is overflow, return MAX_INT.
     */
    public class OJ029_DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0 || divisor == 0)
                return 0;

            bool isNeg = false;
            if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
                isNeg = true;

            long result = 0;

            //abs(-2147483648)会溢出，因为正数int只能到2147483647
            long lDividend = Math.Abs((long)dividend);
            long lDivisor = Math.Abs((long)divisor);
            while (lDividend >= lDivisor)
            {
                long count = 1;
                long sum = lDivisor;
                while (lDividend >= sum)
                {
                    sum = sum << 1; //左移一位相当于乘以2
                    count = count << 1;
                }

                lDividend -= sum >> 1;
                result += count >> 1;
            }

            result = isNeg ? (0 - result) : result;
            return result > int.MaxValue ? int.MaxValue : (int)result;
        }
    }
}
