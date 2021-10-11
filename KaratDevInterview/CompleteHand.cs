using System;
using System.Collections.Generic;
using System.Linq;

namespace KaratDevInterview
{
    public static class CompleteHand
    {
        public static string Solution(string tiles) {
            // Your code here.
            // return "NOT COMPLETE";
            var group = new List<int>();
            int count = 0;
            var check = tiles[0];
            int index = 0;
            foreach (var hand in tiles)
            {
                if (check.Equals(hand))
                {
                    count += 1;
                }
                else
                {
                    check = hand;
                    count = 1;
                }

                if (count == 2)
                {
                    group.Add(count);
                }
                else if (count == 3)
                {
                    group[index] = count;
                    index += 1;
                }
                else if (count > 3)
                {
                    count = 1;
                }
                
            }

            var pair = group.Count(v => v == 2);
            var triple = group.Count(v => v == 3);

            if (pair == 1 && triple >= 0)
            {
                return "COMPLETE";
            }
            return "NOT COMPLETE";
        }
    }
}