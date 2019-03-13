using System;

namespace Solutions.DP
{

    // 300. Longest Increasing Subsequence
    // Classic O(N^2) solution https://www.youtube.com/watch?v=CE2b_-XfVDk
    // Solution using O(N*logN) https://www.youtube.com/watch?v=S9oUiVYEq7E
    public class LongestIncreasingSubsequenceSolution
    {
        public int LengthOfLIS(int[] nums)
        {

            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            var solution = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                solution[i] = 1;
            }

            for (var i = 1; i < nums.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        solution[i] = Math.Max(solution[i], solution[j] + 1);
                    }
                }
            }

            var maxLength = solution[0];
            for (var i = 1; i < solution.Length; i++)
            {
                maxLength = Math.Max(solution[i], maxLength);
            }

            return maxLength;

        }
    }
}