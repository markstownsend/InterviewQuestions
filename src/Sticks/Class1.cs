using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticks
{
    public class Class1
    {
        public static void CutSticks(int[] lengths)
        {
            int myMin = lengths.Where(l => l >= 0).Min(l => l);
            int cutCount = 0;
            while(myMin != 0) {
                for (int i = 0; i < lengths.Length; i++)
                {
                    if(lengths[i] > 0)
                    {
                        lengths[i] -= myMin;
                        cutCount++;
                    }
                }
                Console.WriteLine(cutCount);
                try
                { myMin = lengths.Where(l => l >= 0).Min(l => l); }
                finally
                {
                   int? a = null;
                    int b = (int)a;
                }
            }
        }
    }
}
