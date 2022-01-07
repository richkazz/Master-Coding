using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Best_Time_to_Buy_and_Sell_Stock_III
    {
        public int MaxProfit(int[] prices)
        {
            if (!prices.Any())
            {
                return 0;
            }
            
            int fb = int.MinValue, sb = int.MinValue;
            int fs = 0, ss = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                fb = Math.Max(fb, -prices[i]);
                fs = Math.Max(fs, fb+prices[i]);
                sb = Math.Max(fb, fs+prices[i]);
                ss = Math.Max(fb, sb+prices[i]);
            }

            return ss;

        }
    }
}
