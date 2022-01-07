using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length % 2==1)
                return false;
            if (s[s.Length - 1] == char.Parse("(")
                    || s[s.Length - 1] == char.Parse("{")
                    || s[s.Length - 1] == char.Parse("["))
            {
                return false;
            }
            LinkedList<char> hold = new LinkedList<char>();
            foreach (var par in s)
            {
               
                if (par == char.Parse("(")
                    || par == char.Parse("{")
                    || par == char.Parse("["))
                {

                     hold.AddLast(par);

                }
                else
                {
                    if (hold.Any())
                    {
                        if (hold.Last.Value == char.Parse("(")&& char.Parse(")") == par)
                        {
                            hold.RemoveLast();
                        }
                        else if(hold.Last.Value == char.Parse("{") && char.Parse("}") == par)
                        {
                            hold.RemoveLast();
                        }
                        else if(hold.Last.Value == char.Parse("[") && char.Parse("]") == par)
                        {
                            hold.RemoveLast();
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                   
                }

               

            }
            if (hold.Any())
                return false;
            return true;
        }
    }
}
