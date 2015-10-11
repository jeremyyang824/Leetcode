using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.
     * The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
     */
    public class OJ036_ValidSudoku
    {
        /*
         * 1. 如果把九宫格按照行从0开始标号，那么数字board[i][j] 位于第 i/3*3+j/3 个九宫格内（3进制）
         * 
         * 2. 在检测行是否合法时，i 表示矩阵的行，j 表示矩阵的列；
         *    检测列是否合法时，i 表示矩阵的列，j 表示矩阵的行；
         *    检测九宫格是否合法时，i 表示九宫格的标号，j 表示九宫格里的每个元素
         *    (第 i 个九宫格里面的第 j 个元素在原矩阵的第 3*(i/3) + j/3 行，第 3*(i%3) + j%3）列)
         */
        public bool IsValidSudoku(char[,] board)
        {
            int[] rowValid = new int[10];
            int[] colValid = new int[10];
            int[] subValid = new int[10];

            for (int i = 0; i < 9; i++)
            {
                rowValid = new int[10];
                colValid = new int[10];
                subValid = new int[10];

                for (int j = 0; j < 9; j++)
                {
                    if (!valid(rowValid, board[i, j] - '0'))
                        return false;
                    if (!valid(colValid, board[j, i] - '0'))
                        return false;
                    if (!valid(subValid, board[3 * (i / 3) + j / 3, 3 * (i % 3) + j % 3] - '0'))
                        return false;
                }
            }

            return true;
        }

        private bool valid(int[] vec, int val)
        {
            if (val < 0)
                return true;    //‘.’
            if (vec[val] == 1)
                return false;
            vec[val] = 1;
            return true;
        }
    }
}
