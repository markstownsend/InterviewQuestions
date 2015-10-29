using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
  
    public static class Solution
    {
        public static int solution(int[] A)
        {
            // establish the starting point
            int lsum = 0;
            int rsum = A.Sum(a => a);
            int minDiff = Math.Abs(lsum - rsum);
            int runningDiff = 0;
            for (int i = 1; i < A.Length; i++)
            {
                lsum += A[i - 1];
                rsum -= A[i - 1];
                runningDiff = Math.Abs(lsum - rsum);
                if (runningDiff < minDiff)
                {
                    minDiff = runningDiff;
                }
            }
            return minDiff;
        }
    }


}
