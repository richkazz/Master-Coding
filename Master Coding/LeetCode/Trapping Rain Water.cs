using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Trapping_Rain_Water
    {
        
        public int Trap(int[] height)
        {
            if (!height.Any())
                return 0;
            int maxLeft = 0, maxRight = 0, i = 0, j = height.Length-1,water = 0;
            while(i< j)
            {
                if(height[i] <= height[j])
                {
                    maxLeft = Math.Max(maxLeft, height[i]);
                    water += maxLeft - height[i];
                    i++;
                }
                else
                {
                    maxRight = Math.Max(maxRight, height[j]);
                    water += maxRight - height[j];
                    j--;
                }
            }
            return water;
        }
    }
}
