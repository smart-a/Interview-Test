using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal
{
    public static class OnlineCode
    {
        public static int[] GetChange(int m, double p)
        {
            var sumChange = new Dictionary<int, int>();
            double change = m - p;
            var dom = new int[] {50, 25, 10, 5, 1 };

            var splitChange = change.ToString("0.##").Split(".");
            
            // var dec = int.Parse(splitChange[1]);
            // if (dec > 0)
            // {
            //     
            //         for (int i=0; i< dom.Length; i++)
            //         {
            //             int toAdd = 0;
            //             if (i + 1 <= dom.Length && dec >= dom[i] && dec < dom[i + 1])
            //             {
            //                 toAdd = dom[i] * dec;
            //             }
            //             sumChange.Add(toAdd);
            //         }
            // }
            // sumChange.Add(int.Parse(splitChange[0]));
            var change2 = int.Parse(splitChange[0]);
            foreach (var coin in dom)
            {
                var check = change2 % coin;
                if (check == 0)
                {
                    
                }
            }


            return Array.Empty<int>(); // sumChange.ToArray();
        }
    }
}