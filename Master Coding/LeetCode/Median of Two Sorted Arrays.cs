using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() && !nums2.Any())
                return 0;
            if (nums1.Any() && !nums2.Any())
                return GetMedian(nums1);
            if (!nums1.Any() && nums2.Any())
                return GetMedian(nums2);
            List<int> merged = new List<int> ();
            int count = -1;
            var lenght = nums2.Length + nums1.Length;
            int j =0;
            int i =0;
            int check = lenght / 2; ;
            bool second = false ;

            while (true)
            {
                if (i != nums1.Length && !second)
                {
                    if (j != nums2.Length)
                    {
                        if (nums1[i] < nums2[j])
                        {
                            merged.Add(nums1[i]);
                            count++;
                            i++;
                        }
                        else
                        {
                            merged.Add(nums2[j]);
                            count++;
                            j++;
                        }
                    }
                    else
                    {
                        merged.Add(nums1[i]);
                        count++;
                        i++;
                    }
                   
                }
                else 
                {
                    merged.Add(nums2[j]);
                    count++;
                    j++;
                }
              
                if (lenght % 2 != 0 && check==count)
                {
                    return merged[count];
                }
                if (lenght % 2 == 0 && check==count)
                {
                    return double.Parse((merged[count ] + merged[count - 1]).ToString())/2;
                }
               
            }
          
           
        }
        public double FindMedianSortedArrays1(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() && !nums2.Any())
                return 0;
            if (nums1.Any() && !nums2.Any())
                return GetMedian(nums1);
            if (!nums1.Any() && nums2.Any())
                return GetMedian(nums2);
            int[] mercged = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, mercged, nums1.Length);
            Array.ConstrainedCopy(nums2, 0, mercged, nums1.Length, nums2.Length);
            Array.Sort(mercged);
            return GetMedian(mercged);

        }
        double GetMedian(int[] array)
        {
            if (array.Length == 1)
                return array[0];
            if (array.Length % 2 != 0)
            {
                return array[array.Length / 2];
            }
            else
            {
                double result = double.Parse((array[array.Length / 2] + array[(array.Length / 2) - 1]).ToString()) / 2;
                return result;
            }       
        }
    }
}
