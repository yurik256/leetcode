using Xunit;

namespace Solutions.Trees.Test
{
    public class IsValidBSTSolutionTest
    {
        private readonly IsValidBSTSolution _solution;

        public IsValidBSTSolutionTest()
        {
            _solution = new IsValidBSTSolution();
        }

        [Fact]
        public void ShouldReturnTrueForEmptyTree()
        {
            TreeNode root = null;

            var result = _solution.IsValidBST(root);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrueForTreeWithOneNode()
        {
            TreeNode root = new TreeNode(123);

            var result = _solution.IsValidBST(root);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(17);

            var result = _solution.IsValidBST(root);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalse_RightSubTreeElementsLessThanNode()
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.right.left = new TreeNode(9);
            root.right.right = new TreeNode(17);

            var result = _solution.IsValidBST(root);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalse_LeftSubTreeElementsBiggerThanNode()
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.right = new TreeNode(11);
            root.right = new TreeNode(15);

            var result = _solution.IsValidBST(root);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalse_LeftSubTreeEqualElements()
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(10);

            var result = _solution.IsValidBST(root);

            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalse_RightSubTreeEqualElements()
        {
            TreeNode root = new TreeNode(10);
            root.right = new TreeNode(10);

            var result = _solution.IsValidBST(root);

            Assert.False(result);
        }
    }
}
