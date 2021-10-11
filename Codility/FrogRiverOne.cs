using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            var check = Enumerable.Range(1, X).ToArray();
            int count = X - 1;
            return A.Skip(count).Select(s =>
                {
                    count++;
                var steps = new HashSet<int>(A.Take(count)).ToArray();
                var stepsTaken = steps.Count(x => check.Any(a => a == x || steps.Contains(a)));
                if (stepsTaken >= X)
                {
                    return count-1;
                }

                return -1;
            }).Where(a=> a > 0).Min();
            
            // for (int i = X; i <= A.Length; i++)
            // {
            //     var steps = new HashSet<int>(A.Take(i)).ToArray();
            //     var stepsTaken = steps.Count(x => check.Any(a => a == x || steps.Contains(a)));
            //     if (stepsTaken >= X)
            //     {
            //         return (i - 1);
            //     }
            // }
            //return -1;
        }
    }
}