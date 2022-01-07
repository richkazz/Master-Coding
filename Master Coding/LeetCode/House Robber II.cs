using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public static class House_Robber_II
    {
        public static int Rob(int[] nums)
        {
            if (nums.Any())
            {
                int numsLength = nums.Length;
                if (numsLength == 1)
                {
                    return nums[0];
                }
                else if (numsLength == 2)
                {
                    return nums.Max();
                }
                else
                {
                    // int[] numRemoveFirstIndex = new int[numsLength - 1];
                    // int[] numRemoveLastIndex = new int[numsLength - 1];
                    //Array.ConstrainedCopy(nums, 0, numRemoveFirstIndex, 0,numsLength - 1);
                    // Array.ConstrainedCopy(nums, 1, numRemoveLastIndex, 0,numsLength-1 );
                    //List<int> numRemoveFirstIndex = new List<int>();
                    //List<int> numRemoveLastIndex = new List<int>();
                    //for(int i = 0; i < numsLength; i++)
                    //{
                    //    if (i != 0)
                    //    {
                    //        numRemoveFirstIndex.Add(nums[i]);
                    //    }
                    //    if (i != numsLength-1)
                    //    {
                    //        numRemoveLastIndex.Add(nums[i]);
                    //    }

                    //}
                    //return Math.Max(RobMax(numRemoveFirstIndex), RobMax(numRemoveLastIndex));

                    return RobMax(nums);
                }
            }
            return 0;
        }
        private static int RobMax(int[] nums)
        {
            List<int> runningArr = new List<int>();
            runningArr.Add(nums[0]);
            runningArr.Add(Math.Max(nums[0], nums[1]));
            
            List<int> runningArr1 = new List<int>();
            runningArr1.Add(nums[1]);
            runningArr1.Add(Math.Max(nums[1], nums[2]));

            for (int i = 2; i < nums.Length; i++)
            {
                if (i > 2)
                {
                    runningArr1.Add(Math.Max(runningArr1[i - 2], runningArr1[i - 3] + nums[i]));

                }
                if (i < nums.Length-1)
                {
                    runningArr.Add(Math.Max(runningArr[i - 1], runningArr[i - 2] + nums[i]));

                }
                
                
            }
            return Math.Max(runningArr.Last(), runningArr1.Last() );
        }
    }
}
