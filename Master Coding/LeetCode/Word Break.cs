using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Word_Break
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            Dictionary<string, bool> memo = new Dictionary<string, bool>();
            return WordBreak(s, wordDict, memo);
        }
        public bool WordBreak(string s, IList<string> wordDict, Dictionary<string, bool> memo)
        {
            if (s == "")
            {
                return true;
            }
            if (memo.ContainsKey(s))
            {
                return memo[s];
            }
            bool found = false;
            foreach (string word in wordDict)
            {
                if (word.Length <= s.Length)
                {
                    if (s.Substring(0, word.Length) == word)
                    {
                        found = found || WordBreak(s.Substring(word.Length), wordDict, memo);
                    }
                }

            }
            memo[s] = found;
            return found;
        }
        public bool WordBreak2(string s, IList<string> wordDict)
        {
            if (!wordDict.Any())
                return false;
            int n = s.Length;
            bool[] dp = new bool[n + 1];
            int maxLenght = 0;
            foreach(string word in wordDict)
            {
                maxLenght = Math.Max(maxLenght, word.Length);
            }
            dp[0] = true;
            for(int i = 0; i <= n; i++)
            {
                for(int j =i-1; j >= 0; j--)
                {
                    if (i - j > maxLenght)
                        continue;
                    if(j + i > n )
                    {
                        if (dp[j] && wordDict.Contains(s.Substring(j)))
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                    else
                    {
                        if (dp[j] && wordDict.Contains(s.Substring(j, i)))
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                    
                }
            }
            return dp[n];
        }
        public bool WordBreak1(string s, IList<string> wordDict)
        {
            if (!wordDict.Any())
                return false;
            var keep = "";
            int count = 0;
            foreach(char alp in s.ToCharArray())
            {
                keep += alp;
                if (wordDict.Contains(keep))
                {
                    //wordDict.Remove(keep);
                    keep = "";
                    
                } else if (count == s.Length - 1&&keep!="")
                {
                    return false;
                }
                
                    count++;
            }
            return true;
        }

    }
}
