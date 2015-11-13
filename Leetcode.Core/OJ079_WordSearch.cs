using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a 2D board and a word, find if the word exists in the grid.
     * The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. 
     * The same letter cell may not be used more than once.
     * For example,
     * Given board =
     * [
     *  ['A','B','C','E'],
     *  ['S','F','C','S'],
     *  ['A','D','E','E']
     * ]
     * word = "ABCCED", -> returns true,
     * word = "SEE", -> returns true,
     * word = "ABCB", -> returns false.
     */
    public class OJ079_WordSearch
    {
        public bool Exist(char[,] board, string word)
        {
            if (word == "")
                return false;

            int m = board.GetLength(0);
            int n = board.GetLength(1);
            bool[,] visited = new bool[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == word[0] && dfs(board, visited, word, 0, i, j))
                        return true;
                }
            }
            return false;
        }

        private bool dfs(char[,] board, bool[,] visited, string word, int wordIdx, int x, int y)
        {
            if (wordIdx >= word.Length)
                return true;

            int m = board.GetLength(0);
            int n = board.GetLength(1);

            //validate
            if (x >= 0 && y >= 0 && x < m && y < n
                && !visited[x, y]
                && board[x, y] == word[wordIdx])
            {
                visited[x, y] = true;
            }
            else
            {
                return false;
            }

            if (dfs(board, visited, word, wordIdx + 1, x + 1, y))
                return true;
            if (dfs(board, visited, word, wordIdx + 1, x, y - 1))
                return true;
            if (dfs(board, visited, word, wordIdx + 1, x - 1, y))
                return true;
            if (dfs(board, visited, word, wordIdx + 1, x, y + 1))
                return true;

            visited[x, y] = false;  //backtracking
            return false;
        }
    }
}
