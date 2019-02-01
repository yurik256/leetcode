namespace Solutions.Strings
{
    public class ValidPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            string trimmedInput = s.Trim();
            if (trimmedInput == string.Empty)
            {
                return true;
            }

            int leftPointer = 0;
            int rightPointer = trimmedInput.Length - 1;

            while (leftPointer < rightPointer)
            {
                char char1 = trimmedInput[leftPointer];
                char char2 = trimmedInput[rightPointer];
                if (!this.IsAlphaNumeric(char1))
                {
                    leftPointer++;
                    continue;
                }

                if (!this.IsAlphaNumeric(char2))
                {
                    rightPointer--;
                    continue;
                }

                char1 = char.ToLower(char1);
                char2 = char.ToLower(char2);

                if (char1 != char2)
                {
                    return false;
                }

                leftPointer++;
                rightPointer--;
            }

            return true;
        }

        public bool IsAlphaNumeric(char character)
        {
            return char.IsLetter(character) || char.IsNumber(character);
        }
    }
}