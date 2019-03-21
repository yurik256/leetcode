using System;

namespace Solutions.MathProblems
{
    // https://leetcode.com/problems/excel-sheet-column-number/
    // 171. Excel Sheet Column Number
    public class ExcelColumnNumberSolution
    {
        public int TitleToNumber(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                result += (int)Math.Pow(26, s.Length - 1 - i) * GetNumber(s[i]);
            }

            return result;
        }

        private int GetNumber(char character)
        {
            return ((int)character) - 64;
        }
    }
}