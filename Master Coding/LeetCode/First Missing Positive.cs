using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class First_Missing_Positive
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (!nums.Any())
                return 0;
            
            int numsLenght = nums.Length;
            if (nums.Length == 1)
            {
                if(nums[0] > 1)
                    return 1;
                if (nums[0] == 1)
                    return 2;
                if (nums[0] < 1)
                    return 1;
            }
          
            int minPositive = int.MaxValue;
            Array.Sort(nums);
            
            var getLowest = GetLowestPositiveNumber(nums, minPositive);
            int index = getLowest.index;
            minPositive = getLowest.minPositive;
            if (minPositive != 1&&minPositive != 0)
                return 1;

            for (var a = index; a < numsLenght; a++)
            {
                if (a != numsLenght - 1)
                {
                    if (nums[a] == nums[a + 1])
                    {
                        continue;
                    }
                }
                if (nums[a] != minPositive)
                {
                    return minPositive;
                }
                minPositive++;
            }
            return minPositive;
        }
        (int index, int minPositive) GetLowestPositiveNumber(int[] nums, int minPositive)
        {
            int index = 0;
            int j = nums.Length - 1;
            int i = 0;
            while (i < j)
            {
                if (nums[i] >= 0 && nums[i] < minPositive)
                {
                    minPositive = Math.Min(nums[i], minPositive);
                    index = i;
                }
                if (nums[j] >= 0 && nums[j] < minPositive)
                {
                    minPositive = Math.Min(nums[j], minPositive);
                    index = j;
                }
                i++;
                j--;
            }
            return (index, minPositive);
        }
    }
}
