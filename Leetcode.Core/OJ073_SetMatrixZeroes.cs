using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.
     * 
     * Follow up:
     * Did you use extra space?
     * A straight forward solution using O(mn) space is probably a bad idea.
     * A simple improvement uses O(m + n) space, but still not the best solution.
     * Could you devise a constant space solution?
     */
    public class OJ073_SetMatrixZeroes
    {
        /*
         * O(m+n)空间：加一行一列记录各行各列是否有0
         * O(1)空间：用矩阵的第一行第一列记录其余各行各列是否有0
         */
        public void SetZeroes(int[,] matrix)
        {
            bool firstRowZero = false;
            bool firstColumnZero = false;

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                if (matrix[i, 0] == 0)
                {
                    firstColumnZero = true;
                    break;
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (matrix[0, j] == 0)
                {
                    firstRowZero = true;
                    break;
                }
            }

            //用第一行、第一列记录该行列是否有0
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            if (firstColumnZero)
            {
                for (int i = 0; i < m; i++)
                    matrix[i, 0] = 0;
            }

            if (firstRowZero)
            {
                for (int j = 0; j < n; j++)
                    matrix[0, j] = 0;
            }
        }
    }
}
