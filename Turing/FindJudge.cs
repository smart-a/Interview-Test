using System.Collections.Generic;
using System.Linq;

namespace Turing;

public class FindJudge
{
    public static int Solution(int n, int[,] trust)
    {
        var left = new List<int>();
        var right = new List<int>();
		
        for(var i = 0; i<trust.GetLength(0); i++){
			
            for(var x = 0; x < trust.GetLength(1); x++){
				
                if(x == 0){
                    left.Add(trust[i,x]);
                }
                else{
                    right.Add(trust[i,x]);
                }
				
            }
        }
        for(var i = 0; i<left.Count; i++){
            if(right.Contains(left[i]))
            {
                var r = left[i];
                right.RemoveAll(x => x == r);
            }
        }
		
		
        //write your solution here
        return right.Any() ? right.Max() : -1;
    }
}