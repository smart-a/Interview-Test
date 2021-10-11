using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Turing
{
    public static class CallPoints
    {
        public static int Solution(string[] ops)
        {
            var sumList = new List<int>();
            foreach (var val in ops)
            {
                if (int.TryParse(val, out int toAdd))
                {
                    sumList.Add(toAdd);
                }
                else
                {
                    if (val == "C")
                    {
                        sumList.RemoveAt(sumList.Count-1);
                    }
                    else if (val == "D")
                    {
                        var index = sumList.Count - 1;
                        sumList.Add(sumList[index] * 2);
                    }
                    else if (val == "+")
                    {
                        var index = sumList.Count - 1;
                        sumList.Add(sumList[index - 1] + sumList[index]);
                    }
                }
            }

            return sumList.Sum();
        }
    }
}