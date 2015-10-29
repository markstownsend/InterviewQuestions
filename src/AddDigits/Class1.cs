using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigits
{
    public class Solution
    {
        public static int AddDigits(int num)
        {
            if (num == 0)
                return 0;
            else
                return new int[] { 9, 1, 2, 3, 4, 5, 6, 7, 8 }[num % 9];
        }
    }
}
