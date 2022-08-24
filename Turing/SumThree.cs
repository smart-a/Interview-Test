using System;
using System.Collections.Generic;
using System.Linq;

namespace Turing;

public class SumThree
{
    public static IList<IList<int>> Solution(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        for(var x=0; x < nums.Length-1; x++){
            for(var i=x+1; i < nums.Length-1; i++){
                
                var arr = nums.ToList();
                arr.RemoveRange(x, 2);
                var first = nums[x];
                var second = nums[i];
                var check = nums[x] + nums[i];

                check = check > 0 ? -check : Math.Abs(check);
                if(arr.Contains(check))
                {
                    var ans = new List<int>
                    {
                        nums[x], nums[i], check * -1
                    };
                    ans.Sort();
                    if (result.Any(r => ans.Except(r).Any()))
                    {
                       result.Add(ans); 
                    }
                    
                }
            }
        }

        return result;
    }  
}