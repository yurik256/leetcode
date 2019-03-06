using System;

namespace Solutions.DP
{
    public class HouseRobberSolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var memo = new int[nums.Length + 1];
            memo[0] = 0;
            memo[1] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                memo[i + 1] = Math.Max(nums[i] + memo[i - 1], memo[i]);
            }

            return memo[memo.Length - 1];
        }

        public int RobRecursive(int[] nums)
        {
            var memo = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                memo[i] = -1;
            }

            return Rob(nums, nums.Length - 1, memo);
        }

        private int Rob(int[] nums, int houseIndex, int[] memo)
        {
            if (houseIndex < 0)
            {
                return 0;
            }

            if (memo[houseIndex] >= 0)
            {
                return memo[houseIndex];
            }

            memo[houseIndex] = Math.Max(nums[houseIndex] + Rob(nums, houseIndex - 2, memo), Rob(nums, houseIndex - 1, memo));

            return memo[houseIndex];
        }
    }
}