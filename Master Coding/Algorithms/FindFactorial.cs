using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Algorithms
{
    public class FindFactorial
    {

        public int FindFactorialRecursive(int number)
        {
            if (number == 1||number==0)
                return number;
            return number * FindFactorialRecursive(number-1);
        }

        int FindFactorialRecursive(int total, int number)
        {
            if (number == 1 || number == 0)
                return total;
            return FindFactorialRecursive(total * number, number - 1); ;
        }
        int ccc = 0;
        public int FibonacciIterativeRecursive1(int n)
        {
            ccc++;
            if (n < 2)
                return n;
            var x = FibonacciIterativeRecursive1(n - 1) + FibonacciIterativeRecursive1(n - 2);
            return x;
        }
        public int FibonacciMaster(int n)//dynamic programming
        {
            var cache =new Dictionary<int, int>();

            int Fib(int x)
            {

                if (cache.ContainsKey(x))
                {
                    return cache[x];
                }
                else
                {
                    if (x < 2)
                        return x;
                    cache[x] = Fib(x - 1) + Fib(x - 2);
                    return cache[x];
                }
            }
            return Fib(n);
        }
        public int FibonacciIterativeRecursive(int n)
        {
            ccc++;
            if (n < 2)
                return n;
            return FibonacciIterativeRecursive(n, 1, 0, 1);
        }

        int FibonacciIterativeRecursive(int n, int count, int a, int b)
        {
            count++;
            ccc++;
            var c = b;
            b = a + b;
            a = c;
            if (count == n)
                return b;
            return FibonacciIterativeRecursive(n, count, a, b);
        }

    }
}
