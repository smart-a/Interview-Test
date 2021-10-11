using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            var diff = new List<int>();
            for (int part = 1; part < A.Length; part++)
            {
                var left = A.Take(part).Sum();
                var right = A.Skip(part).Sum();
                diff.Add(Math.Abs(left-right));
            }
            return diff.Min();
        }
    }
}