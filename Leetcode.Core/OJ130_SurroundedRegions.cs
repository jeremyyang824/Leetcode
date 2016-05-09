using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a 2D board containing 'X' and 'O', capture all regions surrounded by 'X'.
     * A region is captured by flipping all 'O's into 'X's in that surrounded region.
     * 
     * For example,
     * X X X X
     * X O O X
     * X X O X
     * X O X X
     * 
     * After running your function, the board should be:
     * X X X X
     * X X X X
     * X X X X
     * X O X X
     */
    public class OJ130_SurroundedRegions
    {
        //只有边缘的O是不被X包围的...
        //先搜索边缘，将O替换为1，再继续搜索该字符的四周，直到没有O被找到。
        //再次搜索整个面板，将O替换成X、将1替换成O。
        public void Solve(char[,] board)
        {
            int r = board.GetLength(0);
            int c = board.GetLength(1);

            if (r <= 2 || c <= 2)
                return;

            //top
            for (int i = 0; i < c; i++)
            {
                if (board[0, i] == 'O')
                    searchMark(i, 0, board, r, c);
            }

            //bottom
            for (int i = 0; i < c; i++)
            {
                if (board[r - 1, i] == 'O')
                    searchMark(i, r - 1, board, r, c);
            }

            //left
            for (int i = 0; i < r - 1; i++)
            {
                if (board[i, 0] == 'O')
                    searchMark(0, i, board, r, c);
            }

            //right
            for (int i = 0; i < r - 1; i++)
            {
                if (board[i, c - 1] == 'O')
                    searchMark(c - 1, i, board, r, c);
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (board[i, j] == '1')
                        board[i, j] = 'O';
                    else if (board[i, j] == 'O')
                        board[i, j] = 'X';
                }
            }
        }

        private void searchMark(int x, int y, char[,] board, int r, int c)
        {
            if (x < 0 || x >= c || y < 0 || y >= r)
                return;
            if (board[y, x] == 'O')
            {
                board[y, x] = '1';
                this.searchMark(x, y - 1, board, r, c);
                this.searchMark(x, y + 1, board, r, c);
                this.searchMark(x - 1, y, board, r, c);
                this.searchMark(x + 1, y, board, r, c);
            }
        }
    }
}
