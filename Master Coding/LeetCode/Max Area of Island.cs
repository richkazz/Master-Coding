using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Max_Area_of_Island
    {
        int max = 0;
        int count = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        dfs(grid, i, j);
                        count = 0;
                    }

                }
            }
            return max;
        }

        void dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != 1) return;
            count++;
            if (grid[i][j] == 1)
            {
                max = Math.Max(max, count);
                grid[i][j] = 2;
                dfs(grid, i - 1, j);
                dfs(grid, i, j - 1);
                dfs(grid, i + 1, j);
                dfs(grid, i, j + 1);
            }


        }
    }
}
