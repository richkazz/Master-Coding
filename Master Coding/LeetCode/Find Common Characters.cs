using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Find_Common_Characters
    {
        public IList<string> CommonChars(string[] words)
        {
            
            var hold = new Dictionary<char, int[]>();
            var result = new List<string>();
            if (words[0] == "")
            {
                return result;
            }
            FillWithFirstWord(words, hold);
            for (var i = 1; i < words.Length; i++)
            {
                if (words[i] == "")
                {
                    return result;
                }
                foreach (char word in words[i])
                {
                    if (hold.ContainsKey(word))
                    {

                        hold[word][0] = i + 1;
                        hold[word][2]++;
                    }

                }
                foreach (var item in hold)
                {
                    if (item.Value[0] != i + 1)
                    {
                        hold.Remove(item.Key);
                    }
                    else
                    {
                        GettingMin(words, hold, result, i, item);
                    }
                }
            }


            return result;
        }

        private static void FillWithFirstWord(string[] words, Dictionary<char, int[]> hold)
        {
            foreach (char word in words[0])
            {
                if (!hold.ContainsKey(word))
                {
                    hold.Add(word, new int[] { 1, 1, 0 });
                }
                else
                {
                    hold[word][1]++;
                }

            }
        }

        private static void GettingMin(string[] words, Dictionary<char, int[]> hold, List<string> result, int i, KeyValuePair<char, int[]> item)
        {
            hold[item.Key][1] = Math.Min(hold[item.Key][1], hold[item.Key][2]);
            hold[item.Key][2] = 0;

            if (i == words.Length - 1)
            {
                for (var j = 0; j < item.Value[1]; j++)
                {
                    result.Add(item.Key.ToString());
                }

            }
        }
    }
}
