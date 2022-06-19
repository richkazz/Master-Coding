using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Graphs
{
    public class Pacific_Atlantic_Water_Flow
    {
        int x, y = 0;
        bool n, e, s, w = false;
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var result = new List<IList<int>>();
            for (var i = 0; i < heights.Length; i++)
            {
                for (var j = 0; j < heights[0].Length; j++)
                {
                    x = i;
                    y = j;
                    dfs(heights, i, j, "N");
                    dfs(heights, i, j, "E");
                    dfs(heights, i, j, "S");
                    dfs(heights, i, j, "W");
                    if ((n || w) && (e || s))
                    {
                        result.Add(new List<int>() { i, j });
                    }
                    n = false;
                    e = false;
                    s = false;
                    w = false;
                }
            }
            return result;
        }
        void dfs(int[][] grid, int i, int j, string direction)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length)
            {
                if (direction == "N")
                    n = true;
                else if (direction == "E")
                    e = true;
                else if (direction == "S")
                    s = true;
                else if (direction == "W")
                    w = true;
                return;
            }
            if (grid[x][y] < grid[i][j])
            {
                return;
            }
            if (direction == "N")
            {
                dfs(grid, i - 1, j, direction);
            }
            else if (direction == "E")
            {
                dfs(grid, i, j + 1, direction);
            }
            else if (direction == "S")
            {
                dfs(grid, i + 1, j, direction);
            }
            else if (direction == "W")
            {
                dfs(grid, i, j - 1, direction);
            }
        }
    }
}
