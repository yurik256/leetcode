using Xunit;

namespace Solutions.Strings
{
    public class CountAndSaySolutionTest
    {
        private readonly CountAndSaySolution _countAndSaySolution;
        public CountAndSaySolutionTest()
        {
            _countAndSaySolution = new CountAndSaySolution();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        public void ShouldReturnCorrectString(int input, string expectedResult)
        {
            var result = _countAndSaySolution.CountAndSay(input);

            Assert.Equal(expectedResult, result);
        }
    }
}
