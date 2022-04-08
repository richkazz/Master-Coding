using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode.Graph
{
    public class Number_of_Closed_Islands
    {
        int count = 0;
        bool island = false;
        public int ClosedIsland(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        count++;
                        island = true;
                        dfs(grid, i, j);
                        if (!island)
                            count--;

                    }
                }
            }
            return count;
        }

        void dfs(int[][] grid, int i, int j)
        {

            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length)
            {
                island = false;
                return;
            }
            if (grid[i][j] == 1)
            {
                return;
            }
            if (grid[i][j] == 0)
            {
                grid[i][j] = 1;
                dfs(grid, i - 1, j);
                dfs(grid, i, j - 1);
                dfs(grid, i + 1, j);
                dfs(grid, i, j + 1);
            }


        }
    }
}
