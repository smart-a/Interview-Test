using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test
{
    public class Model
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public Model ToModel(string line)
        {
            this.Name = line.Split(" ")[0];
            this.Status = line.Split(" ")[1];
            return this;
        }
    }
    
    public static class CountMissingBadge
    {
        public static string solution(string pairs)
        {
            var missBadge = new List<Model>();
            var pLines = pairs.Split("\n").Select(p=> new Model().ToModel(p)).ToList();
            for(int i=0; i<pLines.Count; i++)
            {

                if (pLines[i] != null)
                {
                    var match = pLines.FirstOrDefault(p =>
                        p != null && p.Name == pLines[i].Name && p.Status != pLines[i].Status);

                    if (match != null)
                    {
                        var index = pLines.IndexOf(match);
                        pLines[index] = null;
                    }
                    else 
                    {
                        missBadge.Add(new Model {Name = pLines[i].Name, Status = pLines[i].Status});
                    }
                }
            }

            var enterBadge = missBadge.Where(m => m.Status == "enter").Select(e=>e.Name).ToArray();
            var exitBadge = missBadge.Where(m => m.Status == "exit").Select(m=>m.Name).ToArray();
            return $"Exited without badge: {enterBadge.Length} # {string.Join(",",enterBadge)}\n" +
                   $"Entered without badge: {exitBadge.Length} # {string.Join(",", exitBadge)}";
        }
    }
}