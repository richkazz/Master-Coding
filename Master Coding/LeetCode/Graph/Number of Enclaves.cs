using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode.Graph
{
    public class Number_of_Enclaves
    {
        int count = 0;
        int total = 0;
        bool check = true;
        public int NumEnclaves(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        dfs(grid, i, j);
                        if (check)
                        {
                            total += count;
                        }
                        check = true;
                        count = 0;
                    }
                }
            }
            return total;
        }

        void dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length)
            {
                check = false;
                return;
            }
            if (grid[i][j] == 0)
            {
                return;
            }
            grid[i][j] = 0;
            count++;
            if (check)
            {
                check = true;
            }
            dfs(grid, i - 1, j);
            dfs(grid, i + 1, j);
            dfs(grid, i, j - 1);
            dfs(grid, i, j + 1);

        }
    }
}
