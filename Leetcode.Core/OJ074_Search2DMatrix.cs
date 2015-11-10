using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
     * 
     * Integers in each row are sorted from left to right.
     * The first integer of each row is greater than the last integer of the previous row.
     * For example,
     * Consider the following matrix:
     * [
     *  [1,   3,  5,  7],
     *  [10, 11, 16, 20],
     *  [23, 30, 34, 50]
     * ]
     * Given target = 3, return true.
     */
    public class OJ074_Search2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int top = 0;
            int bottom = m - 1;
            while (top <= bottom)
            {
                int mid = (top + bottom) / 2;
                int val = matrix[mid, 0];
                if (target > val)
                    top = mid + 1;
                else if (target < val)
                    bottom = mid - 1;
                else
                    return true;
            }

            int row = bottom;
            if (row < 0)
                return false;

            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int val = matrix[row, mid];
                if (target > val)
                    left = mid + 1;
                else if (target < val)
                    right = mid - 1;
                else
                    return true;
            }

            return false;
        }
    }
}
