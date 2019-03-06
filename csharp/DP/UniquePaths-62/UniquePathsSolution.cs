namespace Solutions.DP
{
    // https://leetcode.com/problems/unique-paths/
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            var memo = new int[m, n];

            for (var i = 0; i < n; i++)
            {
                memo[0, i] = 1;
            }

            for (var j = 0; j < m; j++)
            {
                memo[j, 0] = 1;
            }


            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    memo[i, j] = memo[i - 1, j] + memo[i, j - 1];
                }
            }

            return memo[m - 1, n - 1];
        }
    }
}