using System;
using AndelaHackerRank.Andela_Final_Interview;

namespace AndelaHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintArray(ArrayRotation.Solution(new []{3, 8, 9, 7, 6}, 3));
            // Console.WriteLine(MinimumSwap.Solution(new []{1, 3, 5, 2, 4, 6, 7}));
            Console.WriteLine(GreatestOccurrenceNum.Solution(new[] {1, 3, 5, 2, 4, 6, 7}));
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