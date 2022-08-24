using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AndelaHackerRank
{
    public class MinimumSwap
    {
        [SuppressMessage("ReSharper", "SwapViaDeconstruction")]
        public static int Solution(int[] arr)
        {
            var countSwap = 0;
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                var newArr = arr.SkipLast(arr.Length-1 - i).ToArray(); //arr.Take(i + 1).ToArray(); //arr[0..(i+1)]; 
                var maxValIndex = Array.IndexOf(newArr, newArr.Max());
                if (i == maxValIndex) continue;
                var temp = arr[i];
                arr[i] = arr[maxValIndex];
                arr[maxValIndex] = temp;
                // (arr[i], arr[maxValIndex]) = (arr[maxValIndex], arr[i]);
                countSwap++;
            }
            return countSwap;
        }

        static void PrintArray(int[] Arr)
        {
            var str = "";
            foreach (var a in Arr)
            {
                str += $"{a} ";
            }
            Console.WriteLine(str);
        }
    }
}