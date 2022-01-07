using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Next_Permutation
    {
        public void NextPermutation(int[] nums)
        {
            if (!nums.Any())
                return;
            if (nums.Max() == nums[0])
            {
                Array.Sort(nums);
                return;
            }

            if (nums.Length == 2)
            {
                var a = nums[0];
                nums[0] = nums[1];
                nums[1] = a;
                return;
            }
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                   
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
           // Array.Sort(nums,0+1,nums.Length- (0 + 1));
        }
        public void Swap(int[] nums,int i,int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public void Reverse(int[] nums,int start)
        {
            int end = nums.Length - 1;
            while(start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }
    }
}
