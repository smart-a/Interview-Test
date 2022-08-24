using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test;

public class PossibleChange
{
    public static string Solution(int[] coins, int val)
    {
        var result = new Dictionary<int, string>();
        for (int i = 0; i < coins.Length; i++)
        {
            var num = 0;
            var count = 0;
            var tempVal = val;
            var valCoin = new List<string>();
            for(int x = i; x < coins.Length; x++)
            {
                var coin = coins[x];
                var check = tempVal % coin;
                if (check == 0)
                {
                    num = tempVal / coin;
                    valCoin.Add($"{num} coin of {coin}");
                    tempVal = check;
                    count += num;
                    break;
                }

                if (check < tempVal)
                {
                    num = (tempVal - check) / coin;
                    valCoin.Add($"{num} coin of {coin}");
                    tempVal = check;
                    count += num;
                }
            }

            if (tempVal == 0)
            {
                if (result.ContainsKey(count))
                {
                    result[count] = string.Join(", ", valCoin);
                    continue;
                }
                result.Add(count, string.Join(", ", valCoin));
            }
        }

        return result.Any()
            ? result.OrderBy(r => r.Key)
                .First().Value
            : "-1";
    }
}