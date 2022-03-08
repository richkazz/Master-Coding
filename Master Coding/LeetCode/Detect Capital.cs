using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Detect_Capital
    {
        public bool DetectCapitalUse(string word)
        {
            if (word == "")
                return false;
            bool isAllCap = true;
            bool isStartingCap = false;
            bool isAllLower = true;
            var hold = word.ToArray();
            for (var i = 0; i < hold.Length; i++)
            {
                if (hold[i] >= 65 && hold[i] <= 90)
                {
                    isStartingCap = false;
                    if (i == 0) isStartingCap = true;
                    
                    isAllLower = false;
                }
                else
                {
                    isAllCap = false;
                }
            }
            if (isAllLower)
                return true;
            if (isAllCap)
                return true;
            if (isStartingCap)
                return true;

            return false;
        }
    }
}
