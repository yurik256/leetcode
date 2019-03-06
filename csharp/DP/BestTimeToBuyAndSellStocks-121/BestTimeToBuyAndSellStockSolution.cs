using System;

namespace Solutions.DP
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public class BestTimeToBuyAndSellStockSolution
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var minStock = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                minStock = Math.Min(minStock, prices[i]);
                profit = Math.Max(profit, prices[i] - minStock);

            }
            return profit;
        }
    }
}