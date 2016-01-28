using System;
using System.Collections.Generic;

namespace Leetcode.Core
{
    /*
     * Given an index k, return the kth row of the Pascal's triangle.
     * For example, given k = 3,
     * Return [1,3,3,1].
     * Note:
     * Could you optimize your algorithm to use only O(k) extra space?
     */
    public class OJ119_PascalsTriangleII
    {
        //对于产生一个新的行用从后往前更新，只需一个O(k)的空间
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> item = new int[rowIndex + 1];
            item[0] = 1;

            for (int i = 1; i <= rowIndex; i++)
            {
                item[i] = 1;
                for (int j = i - 1; j > 0; j--)
                {
                    item[j] = item[j - 1] + item[j];
                }
                item[0] = 1;
            }
            return item;
        }
    }
}
