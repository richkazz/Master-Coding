using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Minimize_Deviation_in_Array
    {
        public int MinimumDeviation(int[] nums)
        {
            var temp = new SortedSet<int>();
            foreach (var item in nums)
            {
                
                if (!temp.Contains(item))
                {
                    if (!isEven(item))
                    {
                        temp.Add(item * 2);
                    }
                    else
                    {
                        temp.Add(item);
                    }
                    
                }
            }
            int diff = temp.Max() -temp.Min();
            while (true)
            {
                var numsMax = temp.Max();
                var numsMin = temp.Min();
                var newMax = 0;
                var newMin = 0;
                diff = Math.Min(diff, numsMax - numsMin);

                if (temp.Count == 1)
                    return 0;
                if (numsMin == numsMax)
                {
                    diff = Math.Min(diff, numsMax - numsMin);

                    return 0;
                }

                if (!isEven(numsMax) && !isEven(numsMin) && ((numsMin * 2) > numsMax))
                {
                    diff = Math.Min(diff, numsMax - numsMin);

                    if ((numsMax - numsMin) < ((numsMin * 2) - numsMax) || temp.Count != 2)
                        return numsMax - numsMin;
                    return (numsMin * 2) - numsMax;
                }
                if (isEven(numsMax))
                {
                    newMax = numsMax / 2;
                    if (newMax >= numsMin)
                    {
                        temp.Remove(numsMax);
                        if (!temp.Contains(newMax))
                        {
                            temp.Add(newMax);
                        }
                    }
                    diff = Math.Min(diff, numsMax - numsMin);

                }
                else
                {
                    if (isEven(numsMin))
                    {
                        diff = Math.Min(diff, numsMax - numsMin);

                        return numsMax - numsMin;
                    }
                    else
                    {
                        diff = Math.Min(diff, numsMax - numsMin);

                        newMin = numsMin * 2;
                        if (newMin < numsMax)
                        {
                            temp.Remove(numsMin);
                            if (!temp.Contains(newMin))
                            {

                                temp.Add(newMin);
                            }
                        }
                        diff = Math.Min(diff, numsMax - numsMin);

                    }
                }

            }

            while (true)
            {
                var numsMax = temp.Max();
                var numsMin = temp.Min();
                var newMax = 0;
                var newMin = 0;
                if (temp.Count == 1)
                    return 0;
                if (numsMin == numsMax)
                {
                    return 0;
                }
               
                if (isEven(numsMax))
                {
                    newMax = numsMax / 2;
                    temp.Remove(numsMax);
                    if (!temp.Contains(newMax))
                    {
                        temp.Add(newMax);
                    }

                }
                else
                {
                    diff = Math.Min(diff, numsMax - numsMin);
                    return diff;
                }
                diff = Math.Min(diff, numsMax - numsMin);


            }

            
        }
        bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
