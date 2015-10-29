

namespace FrogJump
{


public static class Solution
    {
        public static int solution(int X, int Y, int D)
        {

            int jumpCount = 0;
            int remaining = Y - X;

            while (remaining > 0)
            {
                remaining -= D;
                jumpCount++;
            }

            return jumpCount;
        }
    }


}
