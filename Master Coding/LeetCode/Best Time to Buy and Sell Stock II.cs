using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Best_Time_to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            if (prices.Length == 1)
            {
                return 0;
            }
            if (prices.Length == 2)
            {
                if (prices[1] > prices[0])
                {
                    return prices[1] - prices[0];
                }
                else
                {
                    return 0;
                }
            }

            int profits = 0,pricesLength = prices.Length; ;
           
            for (var i = 0; i < pricesLength; i++)
            {
               if(i != pricesLength-1)
               {
                    reduceSpeed(i);

               }

            }
           
            void reduceSpeed(int i)
            {
                if (prices[i + 1] > prices[i])
                {
                    profits += prices[i + 1] - prices[i];
                }
               
            }
            return profits;

        }
        
    }
}
