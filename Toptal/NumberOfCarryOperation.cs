using System.Globalization;
using System.Linq;

namespace Toptal;

public class NumberOfCarryOperation
{
    public static int Solution(int top, int down)
    {
        var topArr = top.ToString().ToCharArray().Reverse().ToArray();
        var downArr = down.ToString().ToCharArray().Reverse().ToArray();
        var loop = new[] {topArr.Length, downArr.Length}.Min();
        var count = 0;
        var reminder = 0;
        for (var i = 0; i < loop; i++)
        {
            var t = char.GetNumericValue(topArr[i]);
            var d = char.GetNumericValue(downArr[i]);
            var ans = t + d + reminder;
            reminder = 0;
            if (ans > 9)
            {
                reminder = int.Parse(ans.ToString(CultureInfo.InvariantCulture)[..^1]);
                count += 1;
            }
        }

        count += (topArr.Length != downArr.Length && topArr.Length > loop) 
            ? topArr[..^loop].Length 
            : downArr[..^loop].Length;

        return count;
    }
}