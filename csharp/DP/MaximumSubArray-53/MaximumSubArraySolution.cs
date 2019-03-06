using System;

namespace Solutions.DP
{
    // https://leetcode.com/problems/maximum-subarray/
    // https://en.wikipedia.org/wiki/Maximum_subarray_problem
    public class MaximumSubArraySolution
    {
        public int MaxSubArray1(int[] nums)
        {
            var maxSum = 0;
            var sum = 0;

            if (nums.Length == 0)
            {
                return 0;
            }

            var maxValue = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                maxValue = Math.Max(nums[i], maxValue);
            }

            if (maxValue < 0)
            {
                return maxValue;
            }


            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > 0)
                {
                    maxSum = Math.Max(sum, maxSum);
                }
                else
                {
                    sum = 0;
                }
            }

            return maxSum;
        }

        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var maxCurrent = nums[0];
            var maxGlobal = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                maxCurrent = Math.Max(nums[i], maxCurrent + nums[i]);
                maxGlobal = Math.Max(maxCurrent, maxGlobal);
            }

            return maxGlobal;
        }
    }
}