using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Flood_Fill
    {
        
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            
            dfs(image, sr, sc, image[sr][sc], newColor);
            return image;
        }

        void dfs(int[][] grid, int i, int j, int color, int newColor)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == newColor || grid[i][j] != color) return;


            if (grid[i][j] == color)
            {
                grid[i][j] = newColor;
                dfs(grid, i - 1, j, color, newColor);
                dfs(grid, i, j - 1, color, newColor);
                dfs(grid, i + 1, j, color, newColor);
                dfs(grid, i, j + 1, color, newColor);
            }


        }
    }
}
