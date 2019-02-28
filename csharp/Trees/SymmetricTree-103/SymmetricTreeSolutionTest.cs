using Xunit;

namespace Solutions.Trees.Test
{
    public class SymmetricTreeSolutionTest
    {
        private readonly SymmetricTreeSolution _solution;

        public SymmetricTreeSolutionTest()
        {
            _solution = new SymmetricTreeSolution();
        }

        [Fact]
        public void ShouldReturnTrue_EmptyTree()
        {
            TreeNode tree = null;

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue_TreeWithOneNode()
        {
            TreeNode tree = new TreeNode(10);

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }


        [Fact]
        public void ShouldReturnTrue_SymmetricTree()
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(10);
            tree.right = new TreeNode(10);

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue_SymmetricTree_TwoLevels_Complete()
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(10);
            tree.left.left = new TreeNode(12);
            tree.left.right = new TreeNode(13);
            tree.right = new TreeNode(10);
            tree.right.left = new TreeNode(13);
            tree.right.right = new TreeNode(12);

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue_SymmetricTree_TwoLevels_NonComplete()
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(10);
            tree.left.left = new TreeNode(12);
            tree.right = new TreeNode(10);
            tree.right.right = new TreeNode(12);

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrue_SymmetricTree_TwoLevels_NonComplete2()
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(10);
            tree.left.right = new TreeNode(13);
            tree.right = new TreeNode(10);
            tree.right.left = new TreeNode(13);

            var result = _solution.IsSymmetric(tree);

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalse_NonSymmetricTree()
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(10);
            tree.left.left = new TreeNode(13);
            tree.right = new TreeNode(10);
            tree.right.left = new TreeNode(13);

            var result = _solution.IsSymmetric(tree);

            Assert.False(result);
        }
    }
}