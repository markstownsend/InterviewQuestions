using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine()) + 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < levels; i++)
            {
                for (int j = 1; j < levels - i; j++)
                {
                    sb.Append(" ");
                }
                for (int j = (levels - i); j < levels; j++)
                {
                    sb.Append("#");
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }

        public static void divide(int a, int b)
        {
            try
            {
                int c = a / b;
            }
            catch (Exception e)
            {
                Console.Write("Exception");
            
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
