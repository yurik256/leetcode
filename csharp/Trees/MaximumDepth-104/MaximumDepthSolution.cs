namespace Solutions.Trees
{
    public class MaximumDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return MaxDepth(root, 1);
        }

        private int MaxDepth(TreeNode node, int depth)
        {
            if (node?.left == null && node?.right == null)
            {
                return depth;
            }

            var leftSubTreeDepth = MaxDepth(node.left, depth + 1);
            var rightSubTreeDepth = MaxDepth(node.right, depth + 1);

            if (leftSubTreeDepth > rightSubTreeDepth)
            {
                return leftSubTreeDepth;
            }
            else
            {
                return rightSubTreeDepth;
            }
        }
    }
}