using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Merge_Intervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length<2)
                return intervals;
            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            List<int[]> holdMerge = new List<int[]>();
           
            for(var i =0; i< intervals.Length; i++)
            {
                if (i != intervals.Length - 1)
                {
                    if (intervals[i][1] >= intervals[i + 1][0])
                    {
                        if (intervals[i][1] > intervals[i + 1][1])
                        {
                            intervals[i + 1][1] = intervals[i][1];
                        }
                        intervals[i + 1] = new int[] { intervals[i][0], intervals[i + 1][1] };
                        
                        continue;
                    }

                    else
                    {
                        holdMerge.Add(intervals[i]);
                    }
                    
                }
                else 
                {
                    holdMerge.Add(intervals[i]);
                }
                
            }
            return holdMerge.ToArray();
        }
        
       
    }
}
