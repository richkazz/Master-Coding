using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class FreqStack
    {
        Dictionary<int, int> valFre;
        SortedDictionary<int, Stack<int>> freVal;
        public FreqStack()
        {
            valFre = new Dictionary<int, int>();
            freVal = new SortedDictionary<int, Stack<int>>();
        }

        public void Push(int val)
        {
            if (!valFre.ContainsKey(val))
            {
                valFre.Add(val, 1);
                var temp = new Stack<int>();
                temp.Push(val);
                if (freVal.ContainsKey(1))
                {
                    freVal[1].Push(val);
                }
                else
                {
                    freVal.Add(1, temp);
                }
                
            }
            else
            {
                IncreaseFrequency(val);
            }
        }
        void IncreaseFrequency(int val)
        {
            var fre = valFre[val];
            //freVal[fre].Remove(val);
            if (freVal[fre].Count == 0)
                freVal.Remove(fre);
            valFre[val]++;
            if (freVal.ContainsKey(fre + 1))
            {
                freVal[fre + 1].Push(val);
            }
            else
            {
                var temp = new Stack<int>();
                temp.Push(val);
                freVal.Add(fre + 1, temp);
            }
        }
        public int Pop()
        { 

           var u = freVal[freVal.Keys.Last()].Pop();
            if (valFre[u] == 1)
            {
                
                if (freVal[1].Count == 0)
                    freVal.Remove(1);
                valFre.Remove(u);
            }
            else
            {
                var fre = valFre[u];
                if (freVal[fre].Count == 0)
                    freVal.Remove(fre);
            
                valFre[u]--;
            }

            return u;
        }
    }
}
