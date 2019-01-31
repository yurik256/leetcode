using System;
using System.Collections.Generic;


namespace Solutions.Strings
{
	public class ValidAnagramSolution
	{
		public bool IsAnagram(string s, string t)
		{
			if (s == null || t == null || s.Length != t.Length)
			{
				return false;
			}

			Dictionary<char, int> lettersCount = new Dictionary<char, int>();

			for (var i = 0; i < s.Length; i++)
			{
				char key = Char.ToLower(s[i]);
				if (lettersCount.ContainsKey(s[i]))
				{
					lettersCount[key] += 1;
				}
				else
				{
					lettersCount.Add(key, 1);
				}
			}

			for (var i = 0; i < t.Length; i++)
			{
				char key = Char.ToLower(t[i]);

				if (lettersCount.ContainsKey(key))
				{
					var characterCount = lettersCount[key];
					if (characterCount == 1)
					{
						lettersCount.Remove(key);
					}
					else
					{
						lettersCount[key] -= 1;
					}
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}
