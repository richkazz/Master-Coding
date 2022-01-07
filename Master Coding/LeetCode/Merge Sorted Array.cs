using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            combineArrays(nums1, nums2,m);
        }
        int[] combineArrays(int[] nums1, int[] nums2,int m)
        {
            if (!nums2.Any())
                return nums1;

          
            int count = -1;
            var lenght = nums2.Length + nums1.Length;
            int j = 0;
            int i = 0;
           
            bool second = false;

            while (true)
            {
               
                if (i != nums1.Length && !second && i < m)
                {
                    if (j != nums2.Length)
                    {
                        if (nums1[i] <= nums2[j])
                        {
                           
                            count++;
                            i++;
                        }
                        else
                        {
                            Flip(nums1, i, nums2, j);
                            count++;
                            if (nums2[j] > nums2[j + 1])
                            {
                                Swap(nums2, j, j + 1);
                            }
                        }
                    }
                }
                else
                {
                    Flip(nums2, j, nums1, i);
                    count++;
                    i++;
                    j++;
                }

                if (i + j == lenght)
                {
                    break;
                }

            }

            return nums1;
        }
        void Swap(int[] array, int first, int second)
        {
            ///for swaping array at two different index
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;

        }
        void Flip(int[] nums1,int i,int[] nums2, int j)
        {
            int temp = nums1[i];
            nums1[i] = nums2[j];
            nums2[j] = temp;
        }
    }
}
