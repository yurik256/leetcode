using System.Collections.Generic;

namespace Solutions.Backtracking
{
    // 46. Permutations
    // https://leetcode.com/problems/permutations/
    public class PermutationsSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var permutation = new List<int>();
            var hashset = new HashSet<int>();

            helper(permutation, result, nums, hashset);

            return result;
        }

        private void helper(IList<int> permutation, IList<IList<int>> result, int[] nums, HashSet<int> numsToSkip)
        {
            if (permutation.Count == nums.Length)
            {
                result.Add(new List<int>(permutation));
            }
            else
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    if (numsToSkip.Contains(nums[i]))
                    {
                        continue;
                    }
                    permutation.Add(nums[i]);
                    numsToSkip.Add(nums[i]);
                    helper(permutation, result, nums, numsToSkip);
                    permutation.RemoveAt(permutation.Count - 1);
                    numsToSkip.Remove(nums[i]);
                }
            }
        }
    }
}