using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EquiIndex
{
    public static class Class1
    {
        public static int Equi(int[] A)
        {
            int result = -1;
	    long lsum = 0L;
            long rsum = 0L;
            if (A.Length == 0)
            {
                result = 0;
            }
            else if(A.Length ==0)
            {
                result = -1;
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    lsum = A.Take(i).Sum();
                    rsum = A.Skip(i+1).Sum();

                    if(lsum == rsum)
                    {
                        result = i;
                        break;
                    }
                   result = -1;
                }
            }
            return -1;
        }
    }
}
