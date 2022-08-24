using System;
using System.Collections.Generic;
using System.Linq;

namespace Turing
{
    public class MainTest
    {
        public static int Solution1(int[] arr)
        {
            // var luckCount = new Dictionary<int, int>();
            // foreach (var v in arr)
            // {
            //     if (luckCount.ContainsKey(v))
            //     {
            //         luckCount[v] += 1;
            //     }
            //     else
            //     {
            //         luckCount.Add(v, 1);
            //     }
            // }
            //
            // var lucks = luckCount
            //     .Where(a => a.Key == a.Value)
            //     .Select(a => a.Key).ToArray();
            //
            // // if(lucks.Length )
            return 1;
        }
        
        public static int[] Solution2(int[] nums)
        {
            Array.Sort(nums);
            var dup = new Dictionary<int, int>();
            var diff = nums[0];
            if (diff > 1)
            {
                var dp = nums.Where(a => nums
                        .Count(b => b == a) == 2).ToArray()
                    .First();
                return new[] {dp, 1};
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i + 1] - nums[i] == 2)
                {
                    diff = nums[i] + 1;
                } 
                if(!dup.ContainsKey(nums[i]))
                    dup.Add(nums[i], nums.Count(a=>a==nums[i]));
            }
            
            

            var d = dup
                .First(a => a.Value == 2);
            Console.WriteLine($"KEY {d.Key} VAL {d.Value}");
            return new[] {d.Key, diff};
        }
    }
}