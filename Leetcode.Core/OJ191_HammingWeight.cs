using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).
     * For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.
     */
    public class OJ191_HammingWeight
    {
        public int HammingWeight(uint n)
        {
            int count;
            for (count = 0; n > 0; count++)
                n &= n - 1; //每次擦除最后一个1（1后面可能有任意多个0）
            return count;
        }
    }
}
