using System;

namespace Toptal.Test
{
    public class TimeConversion
    {
        public static string Solution(string s)
        {
            var tt = s.Substring(s.Length - 2);
            var timeArr = s.Substring(0, s.Length - 2).Split(':');
            
            if (tt == "AM")
            {
                if (timeArr[0] == "12")
                {
                    timeArr[0] = "00";
                }
            }
            else if (tt == "PM")
            {
                if (int.Parse(timeArr[0]) >= 1 && int.Parse(timeArr[0]) <= 11)
                {
                    timeArr[0] = $"{int.Parse(timeArr[0]) + 12}";
                }
            }

            return string.Join(":", timeArr);
        }
    }
}