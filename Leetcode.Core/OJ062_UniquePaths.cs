using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
     * The robot can only move either down or right at any point in time. 
     * The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
     * How many possible unique paths are there?
     */
    public class OJ062_UniquePaths
    {
        /*
         * 因为每次都只能向下和向右行走，因此对每个方格来说只能从它左边和上边的格子进入当前方格，
         * 从起点开始到达当前方格的路径数量也就等于从起点开始分别到它左边和上边方格的路径数的总和。
         */
        //public int UniquePaths(int m, int n)
        //{
        //    if (m == 1 || n == 1)
        //        return 1;
        //    return UniquePaths(m - 1, n) + UniquePaths(m, n - 1);
        //}

        /*
         * 动态规划，二维数组版
         * A[i][j] = A[i-1][j] + A[i][j-1]
         */
        //public int UniquePaths(int m, int n)
        //{
        //    int[,] map = new int[m, n];
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (i == 0 || j == 0)
        //                map[i, j] = 1;
        //            else
        //                map[i, j] = map[i - 1, j] + map[i, j - 1];
        //        }
        //    }
        //    return map[m - 1, n - 1];
        //}

        /*
         * 动态规划，一维数组版
         * 从第二行开始更新数组值，每次都存储当前行的值
         * A[j] += [j-1]
         */
        public int UniquePaths(int m, int n)
        {
            int[] map = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                        map[j] = 1;
                    else
                        map[j] += map[j - 1];
                }
            }
            return map[n - 1];
        }
    }
}
