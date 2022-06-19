using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode.Graph
{
    public class Game_of_Life
    {
        public void GameOfLife(int[][] board)
        {
            var result = new int[board.Length][];
            for (var i = 0; i < board.Length; i++)
            {
                result[i] = new int[board[i].Length];
                for (var j = 0; j < board[0].Length; j++)
                {
                    var count = Count(board, i, j);
                    Swap(board, result, i, j, count);
                }
            }

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[0].Length; j++)
                {
                    board[i][j] = result[i][j];
                }
            }

        }
        void Swap(int[][] board,int[][] result, int i, int j, int count)
        {
            if (board[i][j] == 0)
            {
                if (count == 3)
                {
                    result[i][j] = 1;
                }
            }
            else
            {
                if (count == 3 || count == 2)
                {
                    result[i][j] = 1;
                }
                else if (count > 3)
                {
                    result[i][j] = 0;
                }
                else if (count < 2)
                {
                    result[i][j] = 0;
                }
            }
        }
        int Count(int[][] board, int i, int j)
        {
            int count = 0;

            if (check(board, i - 1, j) && board[i - 1][j] == 1)
            {
                count++;
            }
            if (check(board, i + 1, j) && board[i + 1][j] == 1)
            {
                count++;
            }
            if (check(board, i, j - 1) && board[i][j - 1] == 1)
            {
                count++;
            }
            if (check(board, i, j + 1) && board[i][j + 1] == 1)
            {
                count++;
            }
            if (check(board, i - 1, j + 1) && board[i - 1][j + 1] == 1)
            {
                count++;
            }
            if (check(board, i - 1, j - 1) && board[i - 1][j - 1] == 1)
            {
                count++;
            }
            if (check(board, i + 1, j + 1) && board[i + 1][j + 1] == 1)
            {
                count++;
            }
            if (check(board, i + 1, j - 1) && board[i + 1][j - 1] == 1)
            {
                count++;
            }
            return count;
        }
        bool check(int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length)
            {

                return false;
            }
            return true;
        }
    }
}
