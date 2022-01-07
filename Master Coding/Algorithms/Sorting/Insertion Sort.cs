using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Algorithms.Sorting
{
    public class Insertion_Sort
    {
        public int[] InsertionSort(int[] array)
        {
            if (!array.Any())
                return array;
            int numberOfTimes = 0;
            int i = 0;
            bool isSearching = false;
            int lastStop =0;
            while (true)
            {
                numberOfTimes++;
                if (i == array.Length-1)
                    break;
                if (array[i] > array[i + 1]&&!isSearching)///check if the next number is less than the previous number
                {
                    lastStop = i;
                    isSearching = true;
                    Swap(array, i, i + 1);
                }
                if (isSearching)///for taking the lowest number to the right position
                {
                    if(i != 0)
                    {
                        if (array[i - 1] > array[i]) //for moving the current minimum number back 
                        {
                            Swap(array, i, i - 1);
                            i--;
                            continue;
                        }
                        else
                        {
                            isSearching = false;
                            i = lastStop; //for returning to the position before shifting the numbers
                            //break;
                        }
                    }
                    else
                    {
                        i = lastStop;//for returning to the position before shifting the numbers
                        isSearching = false;
                    }
                   
                }
                i++;
            }
            return array;
        }
        void Swap(int[] array, int first,int second)
        {
            ///for swaping array at two different index
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
            
        }
        void Shift(int[] nums)
        {
            for (var i = nums.Length - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
        }

    }
}
