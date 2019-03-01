using System.Collections.Generic;
using Xunit;

namespace Solutions.Trees.Test
{
    public class LevelOrderTraversalSolutionTest
    {
        private readonly LevelOrderTraversalSolution _solution;

        public LevelOrderTraversalSolutionTest()
        {
            _solution = new LevelOrderTraversalSolution();
        }

        [Fact]
        public void NonEmptyTree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var expectedResult = new List<IList<int>>();
            expectedResult.Add(new List<int> { 3 });
            expectedResult.Add(new List<int> { 9, 20 });
            expectedResult.Add(new List<int> { 15, 7 });

            var result = _solution.LevelOrder(root);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void EmptyTree()
        {
            TreeNode root = null;

            var expectedResult = new List<IList<int>>();

            var result = _solution.LevelOrder(root);

            Assert.Equal(expectedResult, result);
        }
    }
}