using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class ReverseString
    {
        public void ReverseStringFunction(char[] s)
        {
            if (!s.Any())
                return;
            int j = s.Length - 1;
            int i = 0;
            while (i > j)
            {
                var a = s[j];
                s[j] = s[i];
                s[i] = a;
            }
        }
    }
}
