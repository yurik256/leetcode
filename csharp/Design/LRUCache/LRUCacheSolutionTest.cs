using Xunit;

namespace Solutions.Design.Tests
{
    public class LRUCacheSolutionTest
    {

        public LRUCacheSolutionTest()
        {
        }

        [Fact]
        public void Test()
        {
            LRUCacheSolution cache = new LRUCacheSolution(2);

            cache.Put(1, 10);
            cache.Put(2, 20);

            var result = cache.Get(1);
            Assert.Equal(10, result);

            // cache.Put(1, 15);

            // result = cache.Get(1);
            // Assert.Equal(15, result);

            // evicts key 2
            cache.Put(3, 30);

            // returns -1 (not found)
            result = cache.Get(2);
            Assert.Equal(-1, result);

            // evicts key 1
            cache.Put(4, 40);

            result = cache.Get(1);
            Assert.Equal(-1, result);

            result = cache.Get(3);
            Assert.Equal(30, result);

            result = cache.Get(4);
            Assert.Equal(40, result);
        }
    }
}