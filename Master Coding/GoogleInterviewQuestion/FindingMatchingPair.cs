using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.GoogleInterviewQuestion
{
    public static class FindingMatchingPair
    {
        public static bool NaiveMethod(int[] array1, int[] array2)
        {
            if (array1.Any() && array2.Any())
            {
                foreach(var num in array1)
                {
                    foreach(var num2 in array2)
                    {
                        if(num == num2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static bool CorrectMethod(int[] array1, int[] array2)
        {
            
            if (array1.Any() && array2.Any())
            {
                Dictionary<int, bool> isFound = new Dictionary<int, bool>();
                foreach (var num in array1)
                {
                    if (!isFound.ContainsKey(num))
                    {
                        isFound.Add(num, true);
                    }
                }
                foreach(var num in array2)
                {
                    if (isFound.ContainsKey(num))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
