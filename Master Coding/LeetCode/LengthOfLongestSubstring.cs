using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class LengthOfLongestSubstring
    {
        public int lengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var max = 0;
            var i = 0;
            var j = 0;
            var count = 0;
            while (j < s.Length)
            {

                if (i == s.Length || set.Contains(s[i]))
                {
                    j = j + 1;
                    i = j;


                    set.Clear();
                    max = Math.Max(max, count);
                    count = 0;

                }
                else
                {
                    set.Add(s[i]);
                    i++;
                    Console.WriteLine(i);
                    count++;
                }
            }
            return max;

        }
    }
}
