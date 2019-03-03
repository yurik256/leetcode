namespace Solutions.Trees
{
    public class SortedArrayToBSTSolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            if (nums.Length == 1)
            {
                return new TreeNode(nums[0]);
            }

            return BuildSubTree(0, nums.Length - 1, nums);
        }
        private TreeNode BuildSubTree(int startIndex, int endIndex, int[] nums)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            var median = startIndex + (endIndex - startIndex) / 2;

            var root = new TreeNode(nums[median]);

            root.left = BuildSubTree(startIndex, median - 1, nums);
            root.right = BuildSubTree(median + 1, endIndex, nums);

            return root;
        }
    }
}