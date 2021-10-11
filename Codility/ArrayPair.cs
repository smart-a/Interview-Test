using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class ArrayPair
    {
        public static int Solution(int[] A)
        {
            var newA = new List<string>(A.Select(a=>a.ToString()));
            for(var i =0; i<newA.Count(); i++)
            {
                if (newA[i] != "null")
                {
                    var index = newA.LastIndexOf(newA[i]);
                    if (index != i)
                    {
                        newA[i] = "null";
                        newA[index] = "null";
                    }
                }
            }

            return int.Parse(newA.Single(a => a != "null"));
        }
    }
}