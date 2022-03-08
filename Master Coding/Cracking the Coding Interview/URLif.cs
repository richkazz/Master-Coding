using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Cracking_the_Coding_Interview
{
    public static class URLif
    {
        public static string URLifMethod(char[] words, int lengthOfWord)
        {
            int j = lengthOfWord -1;
            for(var i = words.Length-1; i>-1; i--)
            {
                if (i == j)
                    break;
                if(words[j] != ' ')
                {
                    Swap(words, i, j );
                    j--;
                }
                else
                {
                    words[i] = '0';
                    words[i-1] = '2';
                    words[i-2] = '%';
                    j --;
                    i -= 2;
                }
            }
            return words.ToString();
        }
        static void Swap(char[] words, int i, int j)
        {
             words[i] = words[j];
             words[j] = ' ';
        }
    }
}
