using Xunit;

namespace Solutions.DP.Tests
{
    public class CoinChangeSolutionTest
    {
        private readonly CoinChangeSolution _solution;
        public CoinChangeSolutionTest()
        {
            _solution = new CoinChangeSolution();
        }

        [Fact]
        public void ShouldReturnCorrectAmountOfCoins()
        {
            var coins = new int[] { 186, 419, 83, 408 };

            var numberOfCoins = _solution.CoinChange(coins, 6249);

            Assert.Equal(20, numberOfCoins);
        }
    }
}