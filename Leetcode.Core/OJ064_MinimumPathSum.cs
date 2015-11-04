using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.
     * Note: You can only move either down or right at any point in time.
     */
    public class OJ064_MinimumPathSum
    {
        /*
         * A[i,j] = Math.Min(A[i-1,j], A[i,j-1]) + grid[i,j]
         */
        public int MinPathSum(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int val = grid[i, j];

                    int minPath;
                    if (i == 0)
                        minPath = grid[i, j - 1];
                    else if (j == 0)
                        minPath = grid[i - 1, j];
                    else
                        minPath = Math.Min(grid[i - 1, j], grid[i, j - 1]);

                    grid[i, j] = val + minPath;
                }
            }
            return grid[m - 1, n - 1];
        }
    }
}
