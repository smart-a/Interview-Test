using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test
{
    public class GemModel
    {
        public string Store { get; set; }
        public string Gem { get; set; }
        public int Count { get; set; }
    }
    
    public static class GemStone
    {
        public static int[] Solution(GemModel[] offers, string[] preference)
        {
            var myGemCount = new List<GemModel>();
            var visitedStore = new List<string>();
            foreach (var p in preference)
            {
                var gem = offers.Where(g =>
                    g.Gem == p && !(visitedStore.Any(v => v == g.Store))).ToArray();
                
                var count = gem.Length > 0 ? gem.Select(g => g.Count)
                        .Aggregate((i, j) => i + j) : 0;

                visitedStore.AddRange(gem.Select(g => g.Store));

                myGemCount.Add(new GemModel{ Gem = p, Count = count });
            }

           

            return myGemCount.Select(g => g.Count).ToArray();
        }
    }
}