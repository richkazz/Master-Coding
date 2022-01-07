using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Algorithms.Sorting
{
    public class Bubble_Sort
    {
        public int[] Sort (int[] array)
        {
            int numberOfTimes = 0;
            if (array.Length == 1)
                return array;
            int i = 0;
            int j = 1;
            int count = array.Length;
            while (true)
            {
                numberOfTimes++;
                if (j == count)
                {
                    j = 1;
                    i = 0;
                    count --;
                    //break;
                }
                if (count == 1)
                {
                    break;
                }
                if (array[i] >= array[j])
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                i++;
                j++;
            }
            return array;
        }
    }
}
