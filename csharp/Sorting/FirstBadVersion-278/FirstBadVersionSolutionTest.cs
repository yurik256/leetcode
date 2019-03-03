using Xunit;

namespace Solutions.Sorting.Test
{
    public class FirstBadVersionSolutionTest
    {
        private readonly FirstBadVersionSolution _solution;

        public FirstBadVersionSolutionTest()
        {
            _solution = new FirstBadVersionSolution();
        }

        [Fact]
        public void ShouldReturnFirstVersionForTheReleaseWithOneVersion()
        {
            _solution.BadVersion = 1;
            var result = _solution.FirstBadVersion(1);

            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(1, 25)]
        [InlineData(3, 25)]
        [InlineData(25, 25)]
        public void ShouldReturnCorrectBadVersion(int badVersion, int versions)
        {
            _solution.BadVersion = badVersion;

            var result = _solution.FirstBadVersion(versions);

            Assert.Equal(badVersion, result);
        }
    }
}