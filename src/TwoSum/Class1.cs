using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
   /// Write a function that, given a list and a target sum, returns zero-based indices of any two distinct elements whose sum is equal to the target sum.If there are no such elements, the function should return null.
   /// For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return any of the following tuples of indices:
   /// 1, 4 (3 + 9 = 12)
   /// 2, 3 (5 + 7 = 12)
   /// 3, 2 (7 + 5 = 12)
   /// 4, 1 (9 + 3 = 12)
    public class Class1
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            // edge cases, nullArg, not 2 or more elements, only one largest element and that is less than half of the sum
            if (list == null) return null;
            if (list.Count < 2) return null;
            var maxTwo = list.Max();
            var countMaxTwo = list.Where(e => e == maxTwo).Count();
            if (Convert.ToDouble(maxTwo) < Math.Round((double) (sum / 2), 0, MidpointRounding.AwayFromZero) && countMaxTwo == 1) return null;

            for (int i = 0; i < list.Count; i++)
            {
                var remaining = sum - list[i];
                for (int j = list.Count -1; j > i; j--)
                {
                    if(remaining - list[j] == 0)  return new Tuple<int, int>(i, j);
                    if(remaining -  list[j] < 0)  break;
                }
            }
            return null;
        }
    }
}
