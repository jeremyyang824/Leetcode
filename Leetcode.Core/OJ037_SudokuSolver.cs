using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Write a program to solve a Sudoku puzzle by filling the empty cells.
     * Empty cells are indicated by the character '.'.
     * You may assume that there will be only one unique solution.
     */
    public class OJ037_SudokuSolver
    {
        private int[,] rowValid = new int[9, 10];
        private int[,] colValid = new int[9, 10];
        private int[,] subValid = new int[9, 10];

        public void SolveSudoku(char[,] board)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (board[i, j] != '.')
                        fill(i, j, board[i, j] - '0');

            solver(board, 0);
        }

        //0 <= index <= 80
        private bool solver(char[,] board, int index)
        {
            if (index > 80)
                return true;

            int row = index / 9,
                col = index % 9;

            if (board[row, col] != '.')
                return solver(board, index + 1);

            for (char val = '1'; val <= '9'; val++)
            {
                if (isValid(row, col, val - '0'))
                {
                    board[row, col] = val;
                    fill(row, col, val - '0');

                    if (solver(board, index + 1))
                        return true;
                    clear(row, col, val - '0');
                }
            }

            board[row, col] = '.';
            return false;
        }

        private void fill(int row, int col, int val)
        {
            rowValid[row, val] = 1;
            colValid[col, val] = 1;
            subValid[row / 3 * 3 + col / 3, val] = 1;
        }

        private bool isValid(int row, int col, int val)
        {
            if (rowValid[row, val] == 0
                && colValid[col, val] == 0
                && subValid[row / 3 * 3 + col / 3, val] == 0)
                return true;
            return false;
        }

        private void clear(int row, int col, int val)
        {
            rowValid[row, val] = 0;
            colValid[col, val] = 0;
            subValid[row / 3 * 3 + col / 3, val] = 0;
        }
    }
}
