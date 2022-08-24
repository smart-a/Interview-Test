using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test;

public class HappyNumber
{
    public static bool Solution(int num)
    {
        var numbers = new List<int>();
        while (true)
        {
            var digits = num.ToString().Select(x => int.Parse(x.ToString())).ToList();
            var sum = digits.Sum(digit => digit * digit);

            foreach (var digit in digits)
                sum += digit * digit;
            
            if (numbers.Contains(sum))
                break;

            numbers.Add(sum);
            num = sum;
        }
        return numbers.LastOrDefault() == 1;
    }
}
