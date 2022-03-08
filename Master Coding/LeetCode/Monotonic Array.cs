using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Monotonic_Array
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length <= 2)
                return true;
            bool isAccending = false;
            bool isDescending = false;
            for (var i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    continue;
                }
                if (nums[i] < nums[i + 1] && !isDescending)
                {
                    isAccending = true;
                    continue;
                }

                if (nums[i] > nums[i + 1] && !isAccending)
                {
                    isDescending = true;
                    continue;
                }
                return false;


            }
            return true;
        }
    }
}
