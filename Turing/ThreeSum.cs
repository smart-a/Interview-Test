using System;
using System.Collections.Generic;
using System.Linq;

namespace Turing;

public class ThreeSum
{
    public static int[] Solution(int[] arr, int num)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            
            for (var x = i+1; x < arr.Length-1; x++)
            {
                var arrList = arr.ToList();
                arrList.RemoveRange(i, 2);
                var check = arr[i] + arr[x];
                if (arrList.Contains(num - check))
                {
                    return new[] {arr[i], arr[x], num - check};
                }
            }
        }
        return Array.Empty<int>();
        
        // var uniq = (new HashSet<int>(arr)).ToArray();
        // return new[] { uniq[2] * -1 };
        //
        // var neg = -uniq[2];
        
    }
}