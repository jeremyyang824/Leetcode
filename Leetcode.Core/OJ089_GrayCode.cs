using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * The gray code is a binary numeral system where two successive values differ in only one bit.
     * Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. 
     * A gray code sequence must begin with 0.
     * For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:
     * 00 - 0
     * 01 - 1
     * 11 - 3
     * 10 - 2
     * 
     * Note:
     * For a given n, a gray code sequence is not uniquely defined.
     * For example, [0,2,3,1] is also a valid gray code sequence according to the above definition.
     * For now, the judge is able to judge based on one instance of gray code sequence. Sorry about that.
     */
    public class OJ089_GrayCode
    {
        /*
         * 对n位二进制的码字，从右到左，以0到n-1编号；
         * 如果二进制码字的第i位和i+1位相同，则对应的格雷码的第i位为0，否则为1（当i+1=n时，二进制码字的第n位被认为是0，即第n-1位不变）
         */
        public IList<int> GrayCode(int n)
        {
            IList<int> result = new List<int>();
            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                //二进制除以2即左移一位
                //i左移一位后与i按位异或，最高位与0异或始终不变
                int gray = (i / 2) ^ i;
                result.Add(gray);
            }
            return result;
        }
    }
}
