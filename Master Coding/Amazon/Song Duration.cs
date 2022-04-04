using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Amazon
{
    public class Song_Duration
    {
        public static List<int> duration(int dur, List<int> song)
        {
            var dic = new Dictionary<int, int>();
            var finish = dur - 30;
            for (var i = 0; i < song.Count; i++)
            {
                var diff = finish - song[i];
                if (!dic.ContainsKey(diff))
                {
                    dic.Add(diff, i);
                }
            }
            var ans = new List<int>();
            var test = 0;
            for (var i = 0; i < song.Count; i++)
            {
                if (dic.ContainsKey(song[i]) && dic[song[i]] != i)
                {
                    var temp = Math.Max(song[i], song[dic[song[i]]]);
                    if (temp > test)
                    {
                        test = temp;
                        ans.Clear();
                        ans.Add(i);
                        ans.Add(dic[song[i]]);
                        dic.Remove(song[dic[song[i]]]);
                        if (dic.ContainsKey(song[i]))
                            dic.Remove(song[i]);

                    }
                    else
                    {
                        ans.Clear();
                        ans.Add(i);
                        ans.Add(dic[song[i]]);
                        dic.Remove(song[dic[song[i]]]);
                        if (dic.ContainsKey(song[i]))
                            dic.Remove(song[i]);
                    }


                }
            }
            if (ans.Count == 0)
                return new List<int>() { -1, -1 };
            return ans;
        }
    }
}
