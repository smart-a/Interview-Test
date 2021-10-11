using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal
{
    public static class SmallestPositive
    {
        public static int solution(int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            var small = A[0];
                for (int i = 0; i < A.Length-1; i++)
                {
                    small = A[i+1];
                    var diff = A[i + 1] - A[i];
                    if ((diff <= 1 && A[i] < 1) || diff > 1)
                    {
                        small = A[i];
                        break;
                    }
                }
            return small < 1 ? 1 : small + 1;
        }
    }
}