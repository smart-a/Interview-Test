using System;

namespace Toptal
{
    public static class BinaryGap
    {
        public static int solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            var start = false;
            var count = 0;
            var gap = 0;
            foreach (var t in binary)
            {
                if (start && t == '0')
                    count++;
                else if (start && t == '1')
                {
                    if (gap < count)
                        gap = count;
                    count = 0;
                }
                if (t == '1')
                    start = true;
            }

            return gap;
        }
    }
}