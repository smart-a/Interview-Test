using System;


namespace Turing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(CallPoints.Solution(new[] { "5","-2","4","C", "D", "9","+","+"}));
            // Console.WriteLine(MainTest.Solution2(new[] {1, 2,3,2}));
            //
            // foreach (var v in MainTest.Solution2(new[] {1, 2,3,2}))
            // {
            //     Console.WriteLine(v);
            // }

 
            // Console.WriteLine("Program to add two numbers");
            // Console.WriteLine();
            //
            // Console.WriteLine("Please enter first number");
            // int first = int.Parse(Console.ReadLine());
            //
            // Console.WriteLine();
            // Console.WriteLine("Please enter second number");
            // int second = int.Parse(Console.ReadLine());
            //
            // Calculus calculus = new Calculus(first, second);
            //
            // Console.WriteLine();
            // Console.WriteLine($"{first} + {second} = {calculus.GetSum()}");

            // var r = ThreeSum.Solution(new[] {1, 2, 0, 4, 5}, 12);
            // Console.WriteLine(string.Join(",", r));
            //
            // var r = SumThree.Solution(new[] {-1,0,1,2,-1,-4});
            // var r = FindSubstring.Solution("barfoothefoobarman", new[] {"foo","bar"});
            
            // foreach (var val in r)
            // {
            //     Console.WriteLine(string.Join(",", val));
            // }
            
            var N = 3;
            var trust = new int[, ] { { 1, 3 }, { 2, 3 }, { 3, 1 } };
            Console.WriteLine(FindJudge.Solution(N, trust));

        }
    }
    
    
}