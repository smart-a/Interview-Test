using System;
using System.Linq;

namespace Codility
{
    public class ArrListLen
    {
        public static int Solution(int[] A)
        {
            var index = 0;
            var count = 1;
            while (true)
            {
                var successor = A[index];
                if (successor < 0)
                {
                    return count;
                }

                count++;
                index = successor;
            }
        }
    }
}