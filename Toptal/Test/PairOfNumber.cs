using System;
using System.Linq;

namespace Toptal.Test
{
    public class PairOfNumber
    {
        public static int[] Solution(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var lookup = num - arr[i];
                if (arr[(i + 1)..].Any(n => n == lookup))
                {
                    return new int[] {arr[i], lookup};
                }
            }

            return Array.Empty<int>();
        }
    }
}