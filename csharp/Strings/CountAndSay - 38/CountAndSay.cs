using System.Text;

namespace Solutions.Strings
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }

            var prevSequence = CountAndSay(n - 1);

            var resultBuilder = new StringBuilder();

            var i = 0;
            var count = 1;

            while (i < prevSequence.Length - 1)
            {
                var current = prevSequence[i];
                var next = prevSequence[i + 1];

                if (current != next)
                {
                    resultBuilder.Append(count);
                    resultBuilder.Append(current);
                    count = 1;
                }
                else
                {
                    count++;
                }

                i++;
            }

            resultBuilder.Append(count);
            resultBuilder.Append(prevSequence[prevSequence.Length - 1]);


            return resultBuilder.ToString();
        }
    }
}

