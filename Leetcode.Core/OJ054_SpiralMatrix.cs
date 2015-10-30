using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
     * For example,
     * Given the following matrix:
     * 
     * [
     *  [ 1, 2, 3 ],
     *  [ 4, 5, 6 ],
     *  [ 7, 8, 9 ]
     * ]
     * You should return [1,2,3,6,9,8,7,4,5].
     */
    public class OJ054_SpiralMatrix
    {
        /*
         * x1,y1记录左上角，x2,y2记录右下角
         */
        public IList<int> SpiralOrder(int[,] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null)
                return result;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int x1 = 0, y1 = 0;
            while (rows >= 1 && cols >= 1)
            {
                int x2 = x1 + rows - 1;
                int y2 = y1 + cols - 1;

                for (int i = y1; i <= y2; i++)
                {
                    result.Add(matrix[x1, i]);
                }

                for (int i = x1 + 1; i < x2; i++)
                {
                    result.Add(matrix[i, y2]);
                }

                if (rows > 1)
                {
                    for (int i = y2; i >= y1; i--)
                    {
                        result.Add(matrix[x2, i]);
                    }
                }

                if (cols > 1)
                {
                    for (int i = x2 - 1; i > x1; i--)
                    {
                        result.Add(matrix[i, y1]);
                    }
                }

                rows -= 2;
                cols -= 2;
                x1++;
                y1++;
            }
            return result;
        }
    }
}
