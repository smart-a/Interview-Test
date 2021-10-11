using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class ArrayRotation
    {
        public static int[] Solution(int[] A, int K) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            if (A.Length > 0)
            {
                 for(int x=1; x <= K; x++)
                 {
                     var newA = A.Take(A.Length-1).ToList();
                     var index = A.Length - 1;
                     newA.Insert(0,A[index]);
                     newA.ToArray().CopyTo(A,0);
                 }
            }
           
            return A;
        }
    }
}