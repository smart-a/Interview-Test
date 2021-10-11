namespace Toptal
{
    public class Tree {
        public int X { set; get; }
        public Tree L { set; get; }
        public Tree R { set; get; }
    }
    
    public static class BinaryTree
    {
        public static int solution(Tree T)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (T == null)
                return 0;

            if (T.L != null || T.R != null)
                return T.L != null ? solution(T.L) + 1 : solution(T.L);
            if  (T.R != null)
                return solution(T.R) + 1;
            
            return solution(T);
        }
    }
}