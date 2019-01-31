using Xunit;

namespace Solutions.Strings
{
	public class ValidAnagramTest
	{
		private readonly ValidAnagramSolution _validAnagramSolution;
		public ValidAnagramTest()
		{
			_validAnagramSolution = new ValidAnagramSolution();
		}

		[Theory]
		[InlineData("123", "12")]
		[InlineData("12", "123")]
		[InlineData("12", "")]
		[InlineData("", "123")]
		[InlineData(null, "123")]
		[InlineData("123", null)]
		public void ShouldReturnFalseWhenStringsHaveDifferentLength(string t, string s)
		{
			var result = _validAnagramSolution.IsAnagram(t, s);

			Assert.False(result);
		}

		[Fact]
		public void ShouldReturnFalseWhenStringsHaveSameLengthButAreNotAnagram()
		{
			var result = _validAnagramSolution.IsAnagram("anagram", "mnagram");

			Assert.False(result);
		}

		[Theory]
		[InlineData("anagram", "nagaram")]
		[InlineData("aNaGram", "Nagaram")]
		public void ShouldReturnTrueWhenStringsAreAnagrams(string s, string t)
		{
			var result = _validAnagramSolution.IsAnagram(s, t);

			Assert.True(result);
		}
	}
}
