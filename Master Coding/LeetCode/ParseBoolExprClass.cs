using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    /*
     * Return the result of evaluating a given boolean expression, represented as a string.

        An expression can either be:

        "t", evaluating to True;
        "f", evaluating to False;
        "!(expr)", evaluating to the logical NOT of the inner expression expr;
        "&(expr1,expr2,...)", evaluating to the logical AND of 2 or more inner expressions expr1, expr2, ...;
        "|(expr1,expr2,...)", evaluating to the logical OR of 2 or more inner expressions expr1, expr2, ...
 

        Example 1:

        Input: expression = "!(f)"
        Output: true
        Example 2:

        Input: expression = "|(f,t)"
        Output: true
        Example 3:

        Input: expression = "&(t,f)"
        Output: false
 

     Constraints:

        1 <= expression.length <= 2 * 104
        expression[i] consists of characters in {'(', ')', '&', '|', '!', 't', 'f', ','}.
        expression is a valid expression representing a boolean, as given in the description.
        Question link: https://leetcode.com/problems/parsing-a-boolean-expression/
     */
    public class ParseBoolExprClass
    {
        public bool ParseBoolExpr(string expression)
        {
            var stack = new Stack<char>();
            foreach (var word in expression)
            {
                if (word == ')')
                {
                    Compute(stack);
                    continue;
                }
                if (word != ',')
                    stack.Push(word);
            }
            char d;
            while (stack.TryPeek(out d))
            {
                Console.WriteLine(stack.Pop());
            }
            return stack.Pop() == 't' ? true : false;
        }
        void Compute(Stack<char> stack)
        {
            var builder = new StringBuilder();

            while (stack.Peek() != '(')
            {
                builder.Append(stack.Pop());
            }
            stack.Pop();
            var opera = stack.Pop();
            var temp = 'a';
            if (opera == '&')
            {
                for (var i = 1; i < builder.Length; i++)
                {
                    if (i == 1)
                        temp = And(builder[i - 1], builder[i]) ? 't' : 'f';
                    else
                        temp = And(temp, builder[i]) ? 't' : 'f';
                }

            }
            else if (opera == '|')
            {
                for (var i = 1; i < builder.Length; i++)
                {
                    if (i == 1)
                        temp = Or(builder[i - 1], builder[i]) ? 't' : 'f';
                    else
                        temp = Or(temp, builder[i]) ? 't' : 'f';
                }
            }
            else
            {
                temp = Not(char.Parse(builder.ToString())) ? 't' : 'f';

            }
            stack.Push(temp);
        }

        bool Or(char s, char s1)
        {
            bool bol1 = s == 't' ? true : false;
            bool bol2 = s1 == 't' ? true : false;
            return bol1 | bol2;
        }
        bool And(char s, char s1)
        {
            bool bol1 = s == 't' ? true : false;
            bool bol2 = s1 == 't' ? true : false;
            return bol1 & bol2;
        }
        bool Not(char s)
        {
            bool bol1 = s == 't' ? true : false;
            return !bol1;
        }
    }
}
