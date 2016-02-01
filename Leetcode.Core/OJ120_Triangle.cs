using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a triangle, find the minimum path sum from top to bottom. Each step you may move to adjacent numbers on the row below.
     * For example, given the following triangle
     * [
     *      [2],
     *     [3,4],
     *    [6,5,7],
     *   [4,1,8,3]
     * ]
     * The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).
     * Note:
     * Bonus point if you are able to do this using only O(n) extra space, where n is the total number of rows in the triangle.
     */
    public class OJ120_Triangle
    {
        /*
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int result = 0;
            if (triangle.Count == 0)
                return result;
            return minimumTotal(triangle, result, 0, 0);
        }

        public int minimumTotal(IList<IList<int>> triangle, int sum, int row, int col)
        {
            sum = sum + triangle[row][col];
            if (triangle.Count - 1 > row)
            {
                int left = int.MaxValue;
                if (col > 0)
                    left = this.minimumTotal(triangle, sum, row + 1, col - 1);

                int mid = this.minimumTotal(triangle, sum, row + 1, col);

                int right = int.MaxValue;
                if (col < triangle[row + 1].Count)
                    right = this.minimumTotal(triangle, sum, row + 1, col + 1);

                return Math.Min(Math.Min(left, mid), right);
            }
            return sum;
        }
        */

        //从下往上（把三角倒过来看），由于下一层的列数大于上一层，因此可以避免边界判断
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count < 1)
                return 0;

            int[] temp = new int[triangle.Count];
            for (int c = 0; c < triangle.Count; c++)
            {
                temp[c] = triangle[triangle.Count - 1][c];
            }
            for (int row = triangle.Count - 2; row >= 0; row--)
            {
                IList<int> colums = triangle[row];
                for (int col = 0; col < row + 1; col++)
                {
                    temp[col] = triangle[row][col] + Math.Min(temp[col], temp[col + 1]);
                }
            }
            return temp[0];
        }
    }
}
