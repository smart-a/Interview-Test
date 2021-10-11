using System;


namespace Turing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(CallPoints.Solution(new[] { "5","-2","4","C", "D", "9","+","+"}));
            Console.WriteLine(MainTest.Solution2(new[] {1, 2,3,2}));

            foreach (var v in MainTest.Solution2(new[] {1, 2,3,2}))
            {
                Console.WriteLine(v);
            }
        }
    }
}