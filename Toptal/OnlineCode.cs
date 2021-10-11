using System.Collections.Generic;

namespace Toptal
{
    public static class OnlineCode
    {
        public static int[] GetChange(int m, double p)
        {
            var sumChange = new List<int>();
            double change = m - p;
            var dom = new int[] {1, 5, 10, 25, 50};

            var splitChange = change.ToString("0.##").Split(".");
            
            var dec = int.Parse(splitChange[1]);
            if (dec > 0)
            {
                
                    for (int i=0; i< dom.Length; i++)
                    {
                        int toAdd = 0;
                        if (i + 1 <= dom.Length && dec >= dom[i] && dec < dom[i + 1])
                        {
                            toAdd = dom[i] * dec;
                        }
                        sumChange.Add(toAdd);
                    }
            }
            sumChange.Add(int.Parse(splitChange[0]));
            return sumChange.ToArray();
        }
    }
}