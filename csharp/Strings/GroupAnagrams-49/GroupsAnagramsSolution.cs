using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Strings
{
    // 49. Group Anagrams
    // https://leetcode.com/problems/group-anagrams/

    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groups = new Dictionary<string, List<string>>();

            for (var i = 0; i < strs.Length; i++)
            {
                var stringArray = strs[i].ToArray();
                Array.Sort(stringArray);
                var sortedString = new string(stringArray);

                if (groups.ContainsKey(sortedString))
                {
                    groups[sortedString].Add(strs[i]);
                }
                else
                {
                    groups[sortedString] = new List<string>() { strs[i] };
                }
            }

            var result = new List<IList<string>>();
            foreach (var anagramGroup in groups)
            {
                var anagrams = anagramGroup.Value;
                result.Add(anagrams);
            }

            return result;

        }
    }
}