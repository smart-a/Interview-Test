using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test
{
    public class plusMinus
    {
        public static void Solution(List<int> arr)
        {
            //var s = arr.ToArray()[..^1].Sum();
            var total = arr.Count;
            var listCount = new Dictionary<string, int>
            {
                {"neg", 0},
                {"zero", 0},
                {"pos", 0}
            };
            foreach(var num in arr)
            {
                switch (num)
                {
                    case < 0:
                        listCount["neg"] += 1;
                        break;
                    case 0:
                        listCount["zero"] += 1;
                        break;
                    case > 0:
                        listCount["pos"] += 1;
                        break;
                }
            }

            // var s = "dfdjkhdf";
            // var d = s[2];
            
            var ans = listCount["pos"]/ (double)total;
            Console.WriteLine(ans.ToString("f6"));
            ans = listCount["neg"]/ (double)total;
            Console.WriteLine(ans.ToString("f6"));
            ans = listCount["zero"]/  (double)total;
            Console.WriteLine(ans.ToString("f6"));
        
        }
    }
}