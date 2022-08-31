using System.Diagnostics;

namespace Amazon.Practice;

public static class PolishNotation
{
    // str -> "5,3,+,2,/"
    public static double Solution(string str)
    {
        var pVal = str.Split(",");
        var result = double.Parse(pVal[0]);
        var nextVal = 0.0;

        for (var i = 1; i < pVal.Length; i++)
        {
            if (!double.TryParse(pVal[i], out var next))
            {
                result = PerformAction(result, nextVal, char.Parse(pVal[i]));
            }

            nextVal = next;
        }

        return result;
    }

    private static double PerformAction(double v1, double v2, char op)
    {
        return op switch
        {
            '+' => v1 + v2,
            '-' => v1 - v2,
            '*' => v1 * v2,
            '/' => v1 / v2,
            _ => v1
        };
    }
}