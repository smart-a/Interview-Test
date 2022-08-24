
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Linq;

namespace SlashDev
{
    public class Model
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(MinimumSwap.Solution(new []{1, 3, 5, 2, 4, 6, 7}));

            // WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/age-counting");
            // WebResponse response = request.GetResponse();
            //
            // string content;
            // using(var reader = new StreamReader(response.GetResponseStream()))
            // {
            //     content = reader.ReadToEnd();
            // }
            //
            // var elementDic = new Dictionary<string, int>();
            // var doc = JsonDocument.Parse(content);
            // var element = doc.RootElement.GetProperty("data"); //EnumerateObject().First().Value;
            // var txt = element.GetRawText().Split(", key");
            // Console.WriteLine($"A: {element}");
            //
            // // var objDoc = JsonDocument.Parse(element).RootElement;
            // foreach (var ele in txt)
            // {
            //     var age = ele.Split("age=");
            //     var ket
            //     elementDic.Add(,
            //         int.Parse(age[1].Substring(age[1].Length-1)));
            // }
            //
            // var count = elementDic.Count(e => e.Value >= 50);
            //
            // Console.WriteLine(count);
            // response.Close();

            // var arr = new int[] {1, 8, 2, 4, 4};
            // List<int> bd = new List<int>();
            // var a = Enumerable.Range(arr[0], arr[1]-arr[0] );
            // var b = Enumerable.Range(arr[2], arr[3] - arr[2] );
            // var count = a.Count(i => b.Contains(i));
            // PrintArray(arr.ToArray());
            // PrintArray(b.ToArray());
            // if(count >= arr[4])
            // {
            //     Console.WriteLine(true);
            //     return;
            // }
            // Console.WriteLine(false);

            // PrintProp(new Model
            // {
            //     Id = 1,
            //     Firstname = "Abeeb",
            //     Lastname = "Adesoye",
            //     Age = 31
            // });

            PrintArray(Enumerable.Range(1, 10).ToArray());



        }

        static void PrintProp(Model model)
        {
            // var (Firstname, Lastname, Age) = model;
            // Console.WriteLine($"Firstname: {Firstname}, Lastame: {Lastname}, Age: {Age}");
        }
        
        static void PrintArray(int[] Arr)
        {
            var str = "";
            foreach (var a in Arr)
            {
                str += $"{a} ";
            }
            Console.WriteLine(str);
        }
    }
}