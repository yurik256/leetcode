using System.Collections.Generic;

namespace Solutions.Strings
{
    // https://leetcode.com/problems/valid-parentheses
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                var current = s[i];
                if (current == '}' || current == ')' || current == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var prevPracket = stack.Pop();
                    if ((current == '}' && prevPracket != '{') ||
                      (current == ')' && prevPracket != '(') ||
                       (current == ']' && prevPracket != '['))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(current);
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }

    }
}