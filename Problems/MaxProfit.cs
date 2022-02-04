
using System;

namespace dsa.Problems
{
    public static class MaxProfit
    {
        public static int GetMaxProfit(int[] prices) {
            int N = prices.Length;
            int min_price = prices[0];
            int max_profit = 0;         
            
            for(int i = 0; i < N; i++)
            {            
                max_profit = Math.Max(max_profit, prices[i] - min_price);
                min_price = Math.Min(min_price, prices[i]);
            }        
        
            return max_profit;
        }
    }
}