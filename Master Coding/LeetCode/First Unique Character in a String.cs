using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public static class First_Unique_Character_in_a_String
    {
        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }
            var dic = new Dictionary<char, int>();
            var di2 = new Dictionary<char, bool>();
            
            for (var i = 0; i < s.Length; i++)
            {
                //may have duplicate
                if (!dic.ContainsKey(s[i])&& !di2.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                //it is a duplicate
                else
                {

                    if (dic.ContainsKey(s[i]))
                    {
                        dic.Remove(s[i]);

                    }
                    if (!di2.ContainsKey(s[i]))
                    {
                        di2.Add(s[i], true);

                    }
                   
                    
                    continue;
                }
             
            }

            for(var i = 0; i < s.Length;i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    return i;
                };
                if (dic.ContainsKey(s[s.Length - 1]))
                {
                    return s.Length -1; 
                };

            }
            
            return -1;

        }
    }
}
