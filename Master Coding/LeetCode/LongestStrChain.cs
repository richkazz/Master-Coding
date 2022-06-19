using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class LongestStrChain
    {
        int longest = 0;
        int max = 0;
        int min = 100011;
        Dictionary<string, int> moize = new Dictionary<string, int>();
        public int LongestStrChainMethod(string[] words)
        {
            var dict = GroupByLength(words);
            int remain = dict.Count;
            for (var i = min; i <= max; i++)
            {
                if (!dict.ContainsKey(i))
                    continue;
                for (var j = 0; j < dict[i].Count; j++)
                {
                    findLongest(dict, i + 1, dict[i][j], 1);
                    
                }
                remain--;
                if (longest > remain)
                    break;
            }
            //Console.Write(IsPredecessor("pdxbc","pcxbcf"));

            return longest;
        }
        Dictionary<int, List<string>> GroupByLength(string[] words)
        {
            var dict = new Dictionary<int, List<string>>();
           
            for (var i = 0; i < words.Length; i++)
            {
                max = Math.Max(max, words[i].Length);
                min = Math.Min(min, words[i].Length);
                if (dict.ContainsKey(words[i].Length))
                {
                    dict[words[i].Length].Add(words[i]);
                }
                else
                {
                    dict.Add(words[i].Length, new List<string>() { words[i] });
                }
            }
            return dict;
        }
        void findLongest(Dictionary<int, List<string>> dict, int index, string s, int longCount)
        {
            longest = Math.Max(longest, longCount);
            if (!dict.ContainsKey(index))
            {
                return;
            }

            for (var i = 0; i < dict[index].Count; i++)
            {
                
                if (IsPredecessor(s, dict[index][i]))
                {
                    if (moize.ContainsKey(dict[index][i]))
                    {
                        longCount += moize[dict[index][i]];
                        longest = Math.Max(longest, longCount);
                        longCount -= moize[dict[index][i]];
                        continue;
                    }
                    longCount++;
                    
                    findLongest(dict, s.Length + 2, dict[index][i], longCount);
                    longCount--;
                    var moi = longest - longCount;
                    if (!moize.ContainsKey(dict[index][i]))
                    {
                        moize.Add(dict[index][i], moi);
                    }
                    
                   
                }
            }
        }
        bool IsPredecessor(string s, string predecessor)
        {
            int j = 0;
            int count = 0;
            for (var i = 0; i < predecessor.Length; i++)
            {
                if (predecessor[i] == s[j])
                {
                    j++;
                    if (j == s.Length)
                        break;
                }
                else
                {
                    count++;
                    if (count == 2)
                        return false;
                }
            }
            return true;
        }
    }
}
