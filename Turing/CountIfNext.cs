using System;
using System.Linq;

namespace Turing
{
    public class CountIfNext
    {
        public static int Solution(int[] arr)
        {
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Skip(i+1).Any(a => Math.Abs(arr[i] - a) == 1))
                {
                    count++;
                }
            }

            return count;
        }
    }
}