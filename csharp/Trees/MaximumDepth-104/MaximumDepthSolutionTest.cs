using Xunit;

namespace Solutions.Trees.Test
{
    public class MaximumDepthSolutionTest
    {
        private readonly MaximumDepthSolution _solution;

        public MaximumDepthSolutionTest()
        {
            _solution = new MaximumDepthSolution();
        }

        [Fact]
        public void ShouldReturnOneForTreeWithOnlyRootNode()
        {
            var root = new TreeNode(1);

            var depth = _solution.MaxDepth(root);

            Assert.Equal(1, depth);
        }

        [Fact]
        public void ShouldReturnZeroForEmptyTree()
        {
            TreeNode root = null;

            var depth = _solution.MaxDepth(root);

            Assert.Equal(0, depth);
        }

        [Fact]
        public void ShouldReturnThreeAsMaxDepth_RightSubTree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var depth = _solution.MaxDepth(root);

            Assert.Equal(3, depth);
        }

        [Fact]
        public void ShouldReturnThreeAsMaxDepth_LeftSubtree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.left.left = new TreeNode(15);
            root.left.right = new TreeNode(7);

            var depth = _solution.MaxDepth(root);

            Assert.Equal(3, depth);
        }

        [Fact]
        public void ShouldReturnTwoAsMaxDepth_OnlyLeftSubtree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);

            var depth = _solution.MaxDepth(root);

            Assert.Equal(2, depth);
        }
    }
}