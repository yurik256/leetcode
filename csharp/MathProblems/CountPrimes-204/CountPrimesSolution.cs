namespace Solutions.MathProblems
{
    // https://leetcode.com/problems/count-primes/
    // https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
    // https://www.youtube.com/watch?v=eKp56OLhoQs&feature
    public class CountPrimesSolution
    {
        public int CountPrimes(int n)
        {
            if (n <= 1)
            {
                return 0;
            }

            var primes = new bool[n + 1];

            for (var i = 0; i < n + 1; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            var count = 0;
            for (var i = 2; i < n; i++)
            {
                if (primes[i])
                {
                    count++;
                    for (var j = 2; i * j <= n; j++)
                    {
                        primes[i * j] = false;
                    }
                }
            }

            return count;
        }
    }
}