using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Longest_Valid_Parentheses
    {
        public static int LongestValidParentheses(string s)
        {
            var stack = new Stack<char>();
            var count = 0;
            var max = 0;
            var con = false;
            var count2 = 0;
            foreach (var par in s)
            {
                if (par == '(')
                {
                    if (count != 0)
                    {
                        con = true;
                    }
                    stack.Push(par);

                    continue;
                }
                if (!stack.Any())
                {
                    continue;
                }

                if ((par == ')' && stack.Peek() != '('))
                {
                    if (!stack.Any())
                    {
                        count += count2;
                        max = Math.Max(count, max);
                    }
                    else
                    {
                        max = Math.Max(count, max);
                        max = Math.Max(count2, max);
                    }
                    stack.Clear();
                    count = 0;
                    count2 = 0;
                    con = false;
                }
                else
                {
                    Console.WriteLine(count.ToString());
                    stack.Pop();
                    if (!con)
                    {
                        count += 2;
                    }
                    else
                    {
                        count2 += 2; ;
                    }

                }
                if (!stack.Any()&& con)
                {
                    if (!stack.Any())
                    {
                        count += count2;
                        max = Math.Max(count, max);
                    }
                    else
                    {
                        max = Math.Max(count, max);
                        max = Math.Max(count2, max);
                    }
                    stack.Clear();
                    count = 0;
                    count2 = 0;
                    con = false;
                }
            }
            if (stack.Count != 0)
            {
                count += count2;
                max = Math.Max(count, max);
            }
            else
            {
                max = Math.Max(count, max);
                max = Math.Max(count2, max);
            }
            return max;
        }
    }
}
