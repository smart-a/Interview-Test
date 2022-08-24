using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test
{
    public class CarsSpace
    {
        public static int Solution(int[] p, int[] s)
        {
            var car = 0;
            Array.Sort(p);
            Array.Reverse(p);
            Array.Sort(s);
            Array.Reverse(s);
            var h = p[2..];
            
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < p.Length; j++)
                {


                    if (p[j] == s[i])
                    {
                        car++;

                        break;
                    }

                    if (s[i] == 0)
                    {
                        break;
                    }

                    
                    if (s[i] > p[j])
                    {
                        s[i] -= p[j];
                    }
                    else
                    {
                        var toAdd = s[i] - p[j];
                        s[i] -= toAdd;
                        car++;
                        break;
                    }

                }
            }

            return car;
        }
        
        private static void print(int[] arr)
        {
            var r = "";
            foreach (var a in arr)
                r += $" {a}";
            Console.WriteLine(r);
            Console.WriteLine();
        }
    }
}