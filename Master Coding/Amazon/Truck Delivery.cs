using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Amazon
{
    public class Truck_Delivery
    {
        static int distance;
        public static int Distance(List<List<int>> area)
        {
            distance = 0;
            consume(area, 0, 0, 0);
            if (distance == 0)
                return -1;
            return distance;
        }
        static void consume(List<List<int>> grid, int i, int j, int count)
        {
            if (i < 0 || j < 0 || i >= grid.Count || j >= grid[0].Count || grid[i][j] == 2 || grid[i][j] == 0) return;

            if (grid[i][j] == 9 && distance == 0)
            {
                distance = count;
                return;
            }
   
            if (grid[i][j] == 1)
            {
                grid[i][j] = 2;
                count++;
                consume(grid, i - 1, j, count);
                consume(grid, i, j - 1, count);
                consume(grid, i + 1, j, count);
                consume(grid, i, j + 1, count);
            }


        }
    }
}
