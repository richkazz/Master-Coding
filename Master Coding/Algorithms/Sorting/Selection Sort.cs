using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Algorithms.Sorting
{
    public class Selection_Sort
    {
        public int[] SelectionSort(int[] array)
        {
            if (array.Length == 1)
                return array;
            int numberOfTimes = 0;
            int nextMinIndex = 0;
            int min = int.MaxValue;
            int nextSortIndex = 0;
            int i = 0;
            while (nextSortIndex != array.Length-1)
            {
                numberOfTimes++;
                if (i == array.Length)
                {
                    int temp = array[nextSortIndex];
                    array[nextSortIndex] = array[nextMinIndex];
                    array[nextMinIndex] = temp;
                    nextSortIndex++;
                    i = nextSortIndex;
                    min = int.MaxValue;
                }
                if(min >= array[i])
                {
                    min = array[i];
                    nextMinIndex = i;
                }
                i++;
            }
            return array;
        }
    }
}
