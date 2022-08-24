using System;
using System.Text;

namespace Toptal.Test
{
    public class CaesarClipher
    {
        public static string Solution(string s, int k)
        {
            var str = new StringBuilder();
        
            foreach (var t in s)
            {
                if(!char.IsLetter(t))
                {
                    str.Append(t);
                    continue;
                }

                k %= 26;
                var ch = t + k;
                
                if(char.IsLower(t) && ch > 122)
                {
                    ch -= 26;
                }
                if(char.IsUpper(t) && ch > 90)
                {
                    ch -= 26;
                }
                str.Append((char)ch);
            }
            return str.ToString();
        }
    }
}