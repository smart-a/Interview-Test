using System.Diagnostics;

namespace Amazon.Practice;

public static class IsBalancedBracket
{
    // str -> "[(<>)](<{}<>>)"
    public static bool Solution(string str)
    {
        var closeList = new List<char>();
        foreach (var @char in str)
        {
            if (IsBracketOpen(@char, out var close))
            {
                closeList.Add(close);
                continue;
            }

            if (closeList.Contains(@char))
            {
                if (closeList.Last() == @char)
                {
                    var lastIndex = closeList.FindLastIndex(x => x == closeList.Last());
                    closeList.RemoveAt(lastIndex);
                }
                else
                {
                    return false;
                }
            }
        }

        return !closeList.Any();
    }

    private static bool IsBracketOpen(char b, out char close)
    {
        close = b switch
        {
            '(' => ')',
            '[' => ']',
            '{' => '}',
            '<' => '>',
            _ => '_'
        };
        return close != '_';
    }
}