using System.Collections.Generic;
using System.Text;

namespace Solutions.Backtracking
{
    // https://leetcode.com/problems/letter-combinations-of-a-phone-number
    public class PhoneLetterCombinationsSolution
    {
        private static Dictionary<char, string> map = new Dictionary<char, string>{
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            if (digits.Length == 0)
            {
                return result;
            }

            var builder = new StringBuilder();
            helper(builder, digits, result);
            return result;
        }

        private void helper(StringBuilder builder, string digits, List<string> values)
        {
            if (builder.Length == digits.Length)
            {
                values.Add(builder.ToString());
                return;
            }

            var digit = digits[builder.Length];
            var characters = map[digit];

            for (var i = 0; i < characters.Length; i++)
            {
                builder.Append(characters[i]);
                helper(builder, digits, values);
                builder.Remove(builder.Length - 1, 1);
            }
        }
    }
}