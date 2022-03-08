using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Unique_Binary_Search_Trees
    {
        public int NumTrees(int n)
        {
            Console.WriteLine("1" + "  =  " +"1");
            int[] catalan = new int[n + 1];
            catalan[0] = 1;
            catalan[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                catalan[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    catalan[i] += catalan[j] * catalan[i - j - 1];
                }
                Console.WriteLine(i.ToString() + "  =  " + catalan[i].ToString());
            }
            return catalan[n];

        }
    }
}
