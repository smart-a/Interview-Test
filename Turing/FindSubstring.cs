using System.Collections.Generic;

namespace Turing;

public class FindSubstring
{
    public static IList<int> Solution(string s, string[] words)
    {
        var result = new List<int>();
        var wCount = words[0].Length;
        var loop = s.Length - wCount;
        var toTake = string.Join("", words).Length;
        for (var i = 0; i < loop; i+=wCount)
        {
            var toCheck = s.Substring(i, toTake);
            var check = 0;
            foreach (var word in words)
            {
                if (toCheck.Contains(word))
                {
                    check++;
                }
            }

            if (check == words.Length)
            {
                result.Add(i);
            }
        }

        return result;
    }
}