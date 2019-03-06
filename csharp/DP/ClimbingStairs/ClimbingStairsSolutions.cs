using System.Collections.Generic;

namespace Solutions.DP
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();

            return GetNextFibonacciNumber(n, memo);
        }

        private int GetNextFibonacciNumber(int n, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n <= 1)
            {
                memo[n] = 1;
            }
            else
            {
                memo[n] = GetNextFibonacciNumber(n - 1, memo) + GetNextFibonacciNumber(n - 2, memo);
            }

            return memo[n];
        }
    }
}