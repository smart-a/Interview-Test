using System.Collections.Generic;
using System.Linq;

namespace AndelaHackerRank.Andela_Final_Interview;

public static class GreatestOccurrenceNum
{
    public static int Solution(int[] nums)
    {
        var uniqs = new HashSet<int>(nums).ToArray();
        var dic = new Dictionary<int, int>();
        foreach (var uniq in uniqs)
        {
            var count = nums.Count(n => n == uniq);
            dic.Add(uniq, count);
        }

        var max = dic.Max(x => x.Key);
        var maxVal = dic.Max(x => x.Value);
        
        if (maxVal == 1 
            || dic.Count(d => d.Value == maxVal) == uniqs.Length)
        {
            return 0;
        }

        if (dic.Count(d => d.Value == maxVal) < uniqs.Length)
        {
            return dic.Where(k => k.Value == maxVal)
                .Max(d => d.Key);
        }

        return max;
    }
}