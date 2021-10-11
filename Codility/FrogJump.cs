namespace Codility
{
    public class FrogJump
    {
        public static int Solution(int X, int Y, int D)
        {
            if (X >= Y)
            {
                return 0;
            }
            return (Y-X) % D == 0 ? (Y-X) / D : (Y-X) / D + 1;
        }
    }
}