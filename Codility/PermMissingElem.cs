using System;

namespace Codility
{
    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
           Array.Sort(A);
           var missing = 1;
           if (A.Length < 1 || A[0] > 1)
           {
               return missing;
           }
           for (int i = 0; i < A.Length; i++)
           {
               if (i + 1 < A.Length && A[i + 1] - A[i] > 1)
               {
                   missing = A[i];
                   break;
               }
               missing = A[i];
           }
           return missing + 1;
        }
    }
}