using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            if(prices.Length == 0)
            {
                return 0;
            }
            if(prices.Length == 1)
            {
                return 0;
            }
            int profits = 0;
            int minVal = prices[0];
            int pricesLength = prices.Length;
           
            int j = pricesLength - 1;
            for(var i = 1; i < pricesLength; i++)
            {
                minVal = Math.Min(minVal,prices[i]);
                if(minVal < prices[i])
                {
                    if((prices[i] - minVal) > profits)
                    profits = prices[i] - minVal;
                }
                else
                {
                    minVal = Math.Min(minVal, prices[i]);
                }

                j--;
            }
            
            return profits;
            
        }
    }
}
