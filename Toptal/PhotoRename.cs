using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Toptal
{
    public class Model
    {
        public string Name { get; set; }
        public string Ext { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
    }
    public static class PhotoRename
    {
        public static string solution(string S)
        {
            var list = new List<Model>();
            foreach (var line in S.Split('\n'))
            {
                var p = line.Split(", ");
                list.Add(new Model()
                {
                    Name = p[0].Split('.')[0],
                    Ext = p[0].Split('.')[1],
                    City = p[1],
                    Date = DateTime.Parse(p[2])
                });
            }

            foreach (var t in list)
            {
                var myNum = list.Where(l => l.City == t.City).OrderBy(o=>o.Date).ToArray();
                var index = Array.FindIndex(myNum, a =>
                    a.Name == t.Name && a.City==t.City && a.Date == t.Date) + 1;

                var padZero = myNum.Count().ToString().Count() <= 2 ? 2 : myNum.Count().ToString().Count();
                t.Name = $"{t.City}{index.ToString($"D{padZero}")}.{t.Ext}";
            }

            return list.Select(l => l.Name).ToList()
                .Aggregate((i, j) => i + "\n" + j);
        }
    }
}