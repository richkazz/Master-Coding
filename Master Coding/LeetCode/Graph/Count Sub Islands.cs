using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode.Graph
{
    public class Count_Sub_Islands
    {
        int total = 0;
        bool check = true;
        public int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            for (var i = 0; i < grid2.Length; i++)
            {
                for (var j = 0; j < grid2[0].Length; j++)
                {
                    if (grid2[i][j] == 1)
                    {
                        dfs(grid2, grid1, i, j);
                        if (check)
                        {
                            total += 1;
                        }
                        check = true;

                    }
                }
            }
            return total;
        }
        void dfs(int[][] grid2, int[][] grid1, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid2.Length || j >= grid2[0].Length || grid2[i][j] != 1)
            {
                return;
            }
            if (grid1[i][j] != 1)
            {
                check = false;
            }
            grid2[i][j] = 2;
            if (check)
            {
                check = true;
            }
            dfs(grid2, grid1, i - 1, j);
            dfs(grid2, grid1, i + 1, j);
            dfs(grid2, grid1, i, j - 1);
            dfs(grid2, grid1, i, j + 1);

        }
    }
}
