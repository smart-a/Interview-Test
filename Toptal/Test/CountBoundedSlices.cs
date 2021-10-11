using System;
using System.Collections.Generic;

namespace Toptal
{
    public static class CountBoundedSlices
    {
        public static int solution(int K, int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int count = 0;
            for(int i=0; i<A.Length; i++)
            {
                var list = new List<int>();
                for(int j=i; j<A.Length; j++)
                {
                    var diff = Math.Abs(A[i] - A[j]);
                    if(diff <= K ){
                        Console.WriteLine($"({i},{j}) - {diff}");
                        list.Add(diff);
                    }
                }

                count += new HashSet<int>(list).Count;
            }
            return count > 1000000000 ?  1000000000 : count;
        }
    }
}