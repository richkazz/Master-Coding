using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode.Graph
{
    public class As_Far_from_Land_as_Possible
    {
        int min = int.MaxValue;
        int y, x, max, distance = 0;
        bool[,] visited;
        public int MaxDistance(int[][] grid)
        {
            visited = new bool[grid.Length, grid[0].Length];
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        y = j;
                        x = i;
                        
                        dfs(grid, i, j);
                        max = Math.Max(max, min);
                        min = int.MaxValue;
                        visited = new bool[grid.Length, grid[0].Length];

                    }
                }
            }

            return max == 0 ? -1 : max;
        }

        void dfs(int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || visited[i,j])
            {

                return;
            }
            distance = Math.Abs(y - j) + Math.Abs(x - i);
            if (distance >= min)
                return;
            visited[i, j] = true;
            if (grid[i][j] == 1)
            {
                
                min = Math.Min(min, distance);
                return;
            }
            if (grid[i][j] == 0)
            {
                dfs(grid, i, j + 1);
                dfs(grid, i + 1, j);
                dfs(grid, i, j - 1);
                dfs(grid, i - 1, j);
            }

        }

       
    }
}
