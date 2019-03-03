namespace Solutions.Sorting
{
    public class FirstBadVersionSolution
    {
        public int BadVersion { get; set; }

        public int FirstBadVersion(int n)
        {
            int min = 1;
            int max = n;

            while (min < max)
            {
                int mid = min + (max - min) / 2;

                if (!IsBadVersion(mid))
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }

            return min;
        }

        private bool IsBadVersion(int version)
        {
            return version >= BadVersion;
        }
    }
}
