using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class BasicCalculator
    {
        public int Calculate1(string s)
        {

            var hold = new StringBuilder();
            var temp = new StringBuilder();
            var temp2 = new StringBuilder();
            var sign = "";
            bool next = false;
            return 1;

        }
        public int Calculate(string s)
        {
           
            var hold = new StringBuilder();
            var temp = new StringBuilder();
            var temp2 = new StringBuilder();
            var sign = "";
            bool next = false;
            foreach (var word in s)
            {
                var wrd = word.ToString();
                if (wrd == " ")
                    continue;
                if (wrd == ")" && temp2.Length != 0)
                {
                    CalcMethod(temp, temp2, sign);
                  
                    hold.Append(temp.ToString());
                    temp2.Clear();
                    temp.Clear();
                    next = false;
                    continue;
                }
                else if(wrd == ")" && temp2.Length == 0)
                {
                    hold.Append(temp.ToString());
                    temp.Clear();
                    next = false;
                    continue;
                }
                if ((wrd == "(" || wrd == ")") && temp.Length != 0)
                {
                    hold.Append(temp.ToString() + sign);
                    sign = "";
                    next = false;
                    temp.Clear();
                }
                else if (wrd == "(" || wrd == ")")
                    continue;
                else
                {
                    if ((temp.Length == 0 &&
                      (wrd != "+" && wrd != "-")) && !next)
                    {
                        temp.Append(wrd);
                    }
                    else if (wrd == "-" || wrd == "+")
                    {
                        if(temp.Length == 0)
                        {
                            hold.Append( wrd);
                            continue;
                        }
                           next = true;
                        if (temp2.Length != 0)
                        {
                            CalcMethod(temp, temp2, sign);
                        }
                        temp2 = new StringBuilder();
                        sign = wrd;
                    }
                    else
                    {
                        temp2.Append(wrd);
                    }
                }
            }
           
           if(temp.Length!=0 && temp2.Length!= 0)
           {
                
                if (hold.Length != 1)
                {
                    CalcMethod(temp, temp2, sign);
                    if (hold[0] == '+' || hold[0] == '-')
                    {
                        
                        var u = hold.ToString() + temp.ToString();
                        temp.Clear();
                        temp.Append(u);
                        var y = Calculate(temp.ToString());
                        return y;
                    }
                }else if(hold.Length == 1)
                {
                    var u = hold.ToString() + temp.ToString();
                    temp.Clear();
                    temp.Append(u);
                    CalcMethod(temp, temp2, sign);
                }
                
                if (temp[0] == '0')
                    return 0;
                var x = int.Parse(temp.ToString());
                return x;
           }
           else if(temp.Length!= 0)
           {
                if((hold[0]=='+' || hold[0] == '-') && hold.Length != 1)
                {
                    hold.Append(temp.ToString());
                    var y = Calculate(hold.ToString());
                    return y;
                }else if(hold[0] == '+' || hold[0] == '-')
                {
                    return int.Parse(hold.Append(temp.ToString()).ToString());
                }
                    
                var x =Calculate(hold.ToString());
                return x;
            }
            else
            {
                var x = Calculate(hold.ToString());
                return x;
            }

        }

        private static void CalcMethod(StringBuilder temp, StringBuilder temp2, string sign)
        {
            var a = int.Parse(temp.ToString());
            int b = int.Parse(temp2.ToString());

            temp.Clear();
            if (sign == "+")
            {
                temp.Append((a + b).ToString());
            }
            else
                temp.Append((a - b).ToString());
        }
    }
}
