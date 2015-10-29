using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.Tests
{
    using System.CodeDom;
    [TestClass]
    public class StairCaseTests
    {
        [TestMethod]
        public void testa()
        {
            
        }
        [TestMethod]
        public static void test()
        {
            int[] a = { 1 };
            StairCaseTests t = new StairCaseTests();
            t.increment(a);
            Console.WriteLine(a[a.Length - 1]);

        }

        void increment (int[] i)
        {
            object o = new string(new char[] { 'h' });
        }
    }


    
}
