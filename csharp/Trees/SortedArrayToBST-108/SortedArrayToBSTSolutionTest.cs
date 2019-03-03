using Xunit;

namespace Solutions.Trees.Test
{
    public class SortedArrayToBSTSolutionTest
    {
        private readonly SortedArrayToBSTSolution _solution;

        public SortedArrayToBSTSolutionTest()
        {
            _solution = new SortedArrayToBSTSolution();
        }

        [Fact]
        public void ShouldReturnNullForEmptyArray()
        {
            var array = new int[] { };

            TreeNode result = _solution.SortedArrayToBST(array);

            Assert.Null(result);
        }

        [Fact]
        public void ShouldReturnTreeWithOneNodeForArrayWithOneItem()
        {
            var array = new int[] { 1 };
            var expectedResult = new TreeNode(1);

            TreeNode result = _solution.SortedArrayToBST(array);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShouldBuiltCorrectTree()
        {
            var array = new int[] { -10, -3, 0, 5, 9 };

            var expectedResult = new TreeNode(0);
            expectedResult.left = new TreeNode(-10);
            expectedResult.left.right = new TreeNode(-3);
            expectedResult.right = new TreeNode(5);
            expectedResult.right.right = new TreeNode(9);

            TreeNode result = _solution.SortedArrayToBST(array);

            Assert.Equal(expectedResult, result);

        }
    }
}
