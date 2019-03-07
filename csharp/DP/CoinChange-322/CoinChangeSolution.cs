using System;

namespace Solutions.DP
{
    // https://leetcode.com/problems/coin-change/
    // https://www.youtube.com/watch?v=NJuKJ8sasGk
    // https://interactivepython.org/runestone/static/pythonds/Recursion/DynamicProgramming.html
    public class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var total = new int[amount + 1];
            total[0] = 0;
            for (var i = 1; i < total.Length; i++)
            {
                total[i] = int.MaxValue - 1;
            }

            for (var j = 0; j < coins.Length; j++)
            {
                for (var i = 1; i < total.Length; i++)
                {
                    if (i >= coins[j])
                    {
                        total[i] = Math.Min(total[i], 1 + total[i - coins[j]]);
                    }
                }
            }

            return (total[amount] == int.MaxValue - 1) ? -1 : total[amount];
        }
    }
}