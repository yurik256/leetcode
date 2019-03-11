namespace Solutions.Searching
{
    // 34. Find First and Last Position of Element in Sorted Array
    // https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class SearchForARangeSolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var startIndex = SearchIndex(nums, target, true);

            if (startIndex == -1)
            {
                return new int[] { -1, -1 };
            }

            var endIndex = SearchIndex(nums, target, false);

            return new int[] { startIndex, endIndex };
        }

        private int SearchIndex(int[] nums, int target, bool searchFirst)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            int result = -1;
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    if (searchFirst)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }
    }
}