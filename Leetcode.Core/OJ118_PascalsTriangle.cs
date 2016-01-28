using System;
using System.Collections.Generic;

namespace Leetcode.Core
{
    /*
     * Given numRows, generate the first numRows of Pascal's triangle.
     * For example, given numRows = 5,
     * Return
     * [
     *      [1],
     *     [1,1],
     *    [1,2,1],
     *   [1,3,3,1],
     *  [1,4,6,4,1]
     * ]
     * 每一层的第i个位置，等于上一层第i-1与第i个位置之和
     */
    public class OJ118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
                return result;

            result.Add(new List<int>() { 1 });
            for (int i = 2; i <= numRows; i++)
            {
                IList<int> item = new List<int>();
                item.Add(1);    //first
                for (int j = 1; j < i - 1; j++)
                {
                    item.Add(result[i - 2][j - 1] + result[i - 2][j]);
                }
                item.Add(1);    //last

                result.Add(item);
            }
            return result;
        }
    }
}
