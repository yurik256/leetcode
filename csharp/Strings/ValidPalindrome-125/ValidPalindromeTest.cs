using Xunit;

namespace Solutions.Strings
{
    public class ValidPalindromTest
    {
        private readonly ValidPalindromeSolution _validPalindromeSolution;
        public ValidPalindromTest()
        {
            _validPalindromeSolution = new ValidPalindromeSolution();
        }

        [Theory]
        [InlineData("")]
        [InlineData("  ")]
        public void ShouldReturnTrueForEmptyString(string input)
        {
            var result = _validPalindromeSolution.IsPalindrome(input);

            Assert.True(result);
        }

        [Theory]
        // [InlineData("A man, a plan, a canal: Panama")]
        [InlineData(" am a    mA    ")]
        public void ShouldReturnTrueForValidPalindrome(string input)
        {
            var result = _validPalindromeSolution.IsPalindrome(input);

            Assert.True(result);
        }

        [Theory]
        [InlineData("race a car")]
        public void ShouldReturnFalseForNonPalindromeString(string input)
        {
            var result = _validPalindromeSolution.IsPalindrome(input);

            Assert.False(result);
        }
    }
}