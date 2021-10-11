using System;


namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintArray(ArrayRotation.Solution(new []{3, 8, 9, 7, 6}, 3));
            Console.WriteLine(FrogRiverOne.Solution(5, new []{1,3,1,4,2,3,5,4}));
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
