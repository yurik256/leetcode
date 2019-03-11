namespace Solutions.Sorting
{
    // 75. Sort Colors
    // https://leetcode.com/problems/sort-colors/
    public class SortColorsSolution
    {
        // https://en.wikipedia.org/wiki/Dutch_national_flag_problem
        public void SortColors(int[] nums)
        {
            var low = 0;
            var reader = 0;
            var high = nums.Length - 1;
            var mid = 1;

            while (reader <= high)
            {
                if (nums[reader] < mid)
                {
                    swap(nums, low, reader);
                    low++;
                    reader++;
                }
                else if (nums[reader] > mid)
                {
                    swap(nums, reader, high);
                    high--;
                }
                else
                {
                    reader++;
                }
            }
        }

        private void swap(int[] nums, int firstIndex, int secondIndex)
        {
            var temp = nums[firstIndex];
            nums[firstIndex] = nums[secondIndex];
            nums[secondIndex] = temp;
        }


        // using counting
        public void SortColors2(int[] nums)
        {
            var countOfZeros = 0;
            var countOfOnes = 0;
            var countOfTwos = 9;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    countOfZeros++;
                }
                if (nums[i] == 1)
                {
                    countOfOnes++;
                }
                if (nums[i] == 2)
                {
                    countOfTwos++;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (countOfZeros > 0)
                {
                    nums[i] = 0;
                    countOfZeros--;
                }
                else if (countOfOnes > 0)
                {
                    nums[i] = 1;
                    countOfOnes--;
                }
                else if (countOfTwos > 0)
                {
                    nums[i] = 2;
                    countOfTwos--;
                }
            }

        }
    }
}