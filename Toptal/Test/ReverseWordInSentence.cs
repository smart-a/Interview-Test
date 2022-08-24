using System;
using System.Collections.Generic;
using System.Linq;

namespace Toptal.Test
{
    public class ReverseWordInSentence
    {
        public static string Solution(string input)
        {
            var reversed = input.Split(" ");
            for (var i = 0; i < reversed.Length; i++)
            {
                reversed[i] = string.Join("", reversed[i].ToCharArray().Reverse());
            }
            return string.Join(" ", reversed.Reverse());
        }

    }
}