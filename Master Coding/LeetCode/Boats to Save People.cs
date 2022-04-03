using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Boats_to_Save_People
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            //remove all value greater or equal to the limit
            var list = new List<int>();
            var boat = 0;
            foreach (var item in people)
            {
                if (item == limit)
                    boat++;
                else
                    list.Add(item);
            }
            if (list.Count == 0)
                return boat;
            else if (list.Count == 1)
            {
                boat++;
                return boat;
            }

            list.Sort();
            int i = 0;
            int j = list.Count - 1;
            int sum = 0;
            while (i <= j)
            {
                sum = list[i] + list[j];
                if (sum > limit)
                {
                    j--;
                    boat++;
                }
                else if (sum <= limit)
                {
                    i++;
                    j--;
                    boat++;
                }
                else if (sum < limit)
                    if (i + 1 != j)
                    {
                        i = check(list, i, j, limit);
                        j--;
                        i++;
                        boat++;
                    }
                    else
                    {
                        boat++;
                        break;
                    }
            }
            return boat;

        }
        int check(List<int> list, int i, int j, int limit)
        {
            int sum = list[i];
            while (i < j)
            {
                if (sum + list[j] < limit)
                {
                    i++;
                    sum += list[i];
                }
                else
                {
                    return i - 1;
                }
            }
            return i;
        }

    }
}
