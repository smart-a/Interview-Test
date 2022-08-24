using System;
using System.Linq;

namespace Toptal.Test
{
    public class MaxProfitWithKTransactions
    {
        public static int Solution(int[] prices, int k)
        {
            var maxSales = 0;
            for(int i=0; i < prices.Length-1; i++){
                var profit = 0;
                var j = i;
                var tranNo = 0;
                while(true)
                {
                    if(tranNo == k) break;
                    
                    var bestSell = prices[j+1];
                    var bestBuy = prices[j+1];
                    var reBuyIndex = -1;
                    for(var s = j+1; s < prices.Length; s++)
                    {
                        if (prices[s] > bestSell && bestBuy == bestSell)
                        {
                            bestSell = prices[s];
                            bestBuy = prices[s];
                        }
                        if(prices[s] <= bestBuy)
                        {
                            bestBuy = prices[s];
                            reBuyIndex = s;
                        }
                        else break;

                    }

                    profit += bestSell - prices[j];
                    Console.WriteLine($"Buy: {prices[j]} - Sell: {bestSell} - Profit: {profit}");
                    
                    if (reBuyIndex < 1  || reBuyIndex >= prices.Length -1)
                        break;

                    j = reBuyIndex;
                    
                    tranNo++;
                    
						
                }
                if(maxSales < profit)
                    maxSales = profit;
                
                Console.WriteLine($"Total Profit: {profit}\n");
			
            }
            return maxSales;
        }
    }
}