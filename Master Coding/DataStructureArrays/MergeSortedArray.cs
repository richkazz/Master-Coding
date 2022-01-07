using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureArrays
{
    public static class MergeSortedArray
    {
        public static void MergeSortedArrayFunction(int[] nums1, int m, int[] nums2, int n)
        {
            for(var i =m; i<m+n; i++)
            {
                nums1[i] = nums2[i - m];
            }

            Array.Sort(nums1);
        }
    }
}
