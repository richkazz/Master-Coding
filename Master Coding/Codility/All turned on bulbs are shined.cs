using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Codility
{
    public class All_turned_on_bulbs_are_shined
    {
        public int solution(int[] a)
        {
            HashSet<int> missing = new HashSet<int>();
            HashSet<int> store = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!store.Contains(i + 1) && i + 1 != a[i])
                    missing.Add(i + 1);
                if (i + 1 < a[i])
                    store.Add(a[i]);
                else
                    missing.Remove(a[i]);
                if (missing.Count == 0)
                    count++;
            }
            return count;
        }

        public int NumTimesAllBlue(int[] flips)
        {
            int count = 0, mx = flips[0], ans = 0;

            for (int i = 0; i < flips.Length; i++)
            {
                if (flips[i] > mx) mx = flips[i];
                count++;
                if (count == mx) ans++;
            }

            return ans;
        }
        

    }
}
