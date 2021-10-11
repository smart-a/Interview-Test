using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal
{
    public static class EndOfYearTransaction
    {
        public static int solution(int[] A, string[] D)
        {
            var cardTranInMonth = new Dictionary<int, int>();
            var sum = 0;
            var countPay = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (D[i].Split('-')[0] == "2020")
                {
                    var month = int.Parse(D[i].Split('-')[1]);
                    if (A[i] < 0)
                    {
                        
                        if (cardTranInMonth.ContainsKey(month))
                        {
                            cardTranInMonth[month] += A[i];
                            countPay[month] += 1;
                        }
                        else
                        {
                            cardTranInMonth.Add(month, A[i]);
                            countPay.Add(month, 1);
                        }
                        // Console.WriteLine($"{month} {cardTranInMonth[month]} - Count: {countPay[month]}");
                    }
                    sum += A[i];
                }
            }

            var debt = 12 - cardTranInMonth.Count(d => 
                Math.Abs(d.Value) >= 100 && countPay[d.Key] >= 3);
            // Console.WriteLine($"debt month = {debt}");
            return sum - (5 * debt);
        }
    }
}