using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Factorial_Trailing_Zeroes
    {
        public int TrailingZeroes(int n)
        {
            BigInteger hold = 1;
            var result = 0;
            for (var i = 1; i <= n; i++)
            {
                hold = i * hold;
            }
            Console.Write(hold.ToString());
            var holdAsArray = hold.ToString().ToArray();
            for (var i = holdAsArray.Length - 1; i > 0; i--)
            {
                if (holdAsArray[i] == '0')
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
