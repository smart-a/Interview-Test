using System;
using System.Linq;

namespace Toptal.Test
{
    public class WordsLimit
    {
        public static string Solution(string message, int k)
        {
            var result = "";
            if(message.Length <= k) return message;

            var temp = message[0..k];
            var tempArr = temp.Split(' ');
            var msgArr = message.Split(' ');
            result = string.Join(" ", tempArr);
            if (!tempArr[^1].Equals(msgArr[tempArr.Length -1]))
            {
                result = string.Join(" ", tempArr.Take(tempArr.Length - 1));
            }
            return result;
        }

        private void print(int[] arr)
        {
            var r = "";
            foreach (var a in arr)
                r += $" {a}";
            Console.WriteLine(r);
            Console.WriteLine();
        }
    }
    
}