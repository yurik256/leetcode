using Xunit;

namespace Solutions.Sorting.Test
{
    public class MergeSortedArraySolutionTest
    {
        private readonly MergeSortedArraySolution _solution;

        public MergeSortedArraySolutionTest()
        {
            _solution = new MergeSortedArraySolution();
        }

        [Fact]
        public void ShouldMergeTwoEmptyArrays()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { };
            int[] expectedResult = new int[] { };

            _solution.Merge(nums1, 0, nums2, 0);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeNonEmptyArrayWithEmptyArray()
        {
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { };
            int[] expectedResult = new int[] { 1, 2, 3 };

            _solution.Merge(nums1, 3, nums2, 0);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeEmptyArrayWithNonEmptyArray()
        {
            int[] nums1 = new int[3];
            int[] nums2 = new int[] { 1, 2, 3 };
            int[] expectedResult = new int[] { 1, 2, 3 };

            _solution.Merge(nums1, 0, nums2, 3);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeTwoArraysValuesInFirstArraySmaller()
        {
            int[] nums1 = new int[6];
            nums1[0] = 1;
            nums1[1] = 2;
            nums1[2] = 3;
            int[] nums2 = new int[] { 4, 5, 6 };
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6 };

            _solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeTwoArraysWhenValuesInSecondArraySmaller()
        {
            int[] nums1 = new int[6];
            nums1[0] = 4;
            nums1[1] = 5;
            nums1[2] = 6;
            int[] nums2 = new int[] { 1, 2, 3 };
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6 };

            _solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeTwoArraysWithEqualValues()
        {
            int[] nums1 = new int[6];
            nums1[0] = 1;
            nums1[1] = 2;
            nums1[2] = 3;
            int[] nums2 = new int[] { 1, 2, 3 };
            int[] expectedResult = new int[] { 1, 1, 2, 2, 3, 3 };

            _solution.Merge(nums1, 3, nums2, 3);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void ShouldMergeTwoArraysWithDifferentSizes()
        {
            int[] nums1 = new int[7];
            nums1[0] = 1;
            nums1[1] = 2;
            int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedResult = new int[] { 1, 1, 2, 2, 3, 4, 5 };

            _solution.Merge(nums1, 2, nums2, 5);

            Assert.Equal(expectedResult, nums1);
        }
    }
}