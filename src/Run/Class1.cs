using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    public class Run
    {
        public static int IndexOfLongestRun(string str)
        {
            if (String.IsNullOrEmpty(str)) return 0;
            if (str.Length == 1) return 0;

            int count = 0;
            int index = 0;
            int maxIndex = 0;
            int maxCount = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxIndex = index;
                        maxCount = count;
                    }
                    count = 0;
                    index = i;
                }
            }

            if (count > maxCount)
            {
                maxIndex = index;
                maxCount = count;
            }

            return maxIndex;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
        }
    }
}