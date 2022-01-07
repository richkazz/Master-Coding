using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Rotate_Array
    {
        public void Rotate1(int[] nums, int k)
        {
            if (nums.Length < 2)
                return;
            while (k > nums.Length||k==nums.Length)
            {
                k = k - nums.Length;
            }
            int a = nums.Length - 1;

            for (var i = 0; i < k; i++)
            {
                Swap(nums, a, i);
               
                a--;
            }
            if (k % 2 != 0)
            {
                a = k - 1;
                int i = 0;
                while (i != a)
                {
                    Swap(nums, a, i);
                    i++;
                    a--;
                }
            }
            else
            {
                a = k - 1;
                int i = 0;
                while (i < a)
                {
                    Swap(nums, a, i);
                    i++;
                    a--;
                }
            }
            if ((nums.Length - k) % 2 != 0)
            {
                a = nums.Length - 1;
                int i = k;
                while (i != a)
                {
                    Swap(nums, a, i);
                    i++;
                    a--;
                }
            }
            else
            {
                a = nums.Length - 1;
                int i = k;
                while (i < a)
                {
                    Swap(nums, a, i);
                    i++;
                    a--;
                }
            }

        }
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length < 2)
                return;
            while (k > nums.Length||k==nums.Length)
            {
                k = k - nums.Length;
            }
            int a = nums.Length - 1;
            var jumper = 0;
            int hold = int.MaxValue;
            if (k == nums.Length/2){
                jjj(nums, k);
                return;
            }
            for (var i = 0; i <= k; i++)
            {
                if (jumper + k < nums.Length - k &&hold==int.MaxValue)
                {
                    hold=  Swap(nums, jumper + k, jumper) ;
                    jumper = jumper + k;
                }
                else if (jumper + k < nums.Length  )

                {
                    hold = Swap(nums, jumper + k, jumper, hold);
                    jumper = jumper + k;
                }
                if (jumper + k >= nums.Length)
                {
                    jumper = jumper - (nums.Length -k);
                    hold = Swap(nums, jumper, jumper, hold);
                }
                
            }
            

         }
        void jjj(int[] nums, int k)
        {
            int a = nums.Length - 1;
            var jumper = 0;
            int hold = int.MaxValue;
            for (var i = 0; i <= k; i++)
            {

                if (jumper + k < nums.Length && hold == int.MaxValue)
                {
                    hold = Swap(nums, jumper + k, jumper);
                    jumper = jumper + k;
                }
                else if (jumper + k < nums.Length)

                {
                    hold = Swap(nums, jumper + k, jumper, hold);
                    jumper = jumper + k;
                }
                if (jumper + k >= nums.Length)
                {
                    jumper = jumper - (nums.Length - k);
                    hold = Swap(nums, jumper, jumper, hold);
                }
                if (k == nums.Length / 2)
                {
                    i++;
                    if (i == k)
                    {
                        break;
                    }
                    i--;
                    jumper++;
                    hold = nums[jumper];
                }
            }

        }
        int Swap(int[] array, int first, int second)
        {
            ///for swaping array at two different index
            int temp = array[first];
            array[first] = array[second];
            
            return temp;
        }
        int Swap(int[] array, int first, int second,int hold)
        {
            ///for swaping array at two different index
            int temp = array[first];
            array[first] = hold;
            
            return temp;
        }

    }
}
