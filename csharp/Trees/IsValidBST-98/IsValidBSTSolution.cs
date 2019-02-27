namespace Solutions.Trees
{
    public class IsValidBSTSolution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode root, int? minValue, int? maxValue)
        {
            if (root == null)
            {
                return true;
            }

            if ((minValue.HasValue && root.val <= minValue.Value) ||
                (maxValue.HasValue && root.val >= maxValue.Value))
            {
                return false;
            }

            return IsValidBST(root.left, minValue, root.val) && IsValidBST(root.right, root.val, maxValue);
        }
    }
}