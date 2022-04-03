using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Codility
{
    public class IndexPositionString
    {
        public int[] find(string[] s)
        {
            var hold = new Dictionary<char, Dictionary<int, int>>();
            for(var i = 0; i<s.Length; i++)
            {
                for(var j = 0; j<s[i].Length; j++)
                {
                    if (!hold.ContainsKey(s[i][j]))
                    {
                        var temp = new Dictionary<int, int>();
                        temp.Add(j, i);
                        hold.Add(s[i][j], temp);
                        continue;
                    }
                    else
                    {
                        if(hold[s[i][j]].ContainsKey(j))
                        {
                            return new int[3] { hold[s[i][j]][j], i, j };
                        }
                        else
                        {
                            hold[s[i][j]].Add(j, i);
                        }
                    }
                }
            }
            return new int[0];
        }

        public int[] find2(string[] s)
        {
            var hold = new Dictionary<char, int>();
            for (var i = 0; i < s[0].Length; i++)
            {
                for (var j = 0; j<s.Length; j++)
                {
                    if (hold.ContainsKey(s[j][i]))
                    {
                        return new int[3] { hold[s[j][i]],  j, i};
                    }
                    else
                    {
                        hold.Add(s[j][i], j);
                    }
                }
                hold.Clear();
            }
            return new int[0];
        }
    }
}
