using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace All.Tests
{
    [TestClass]
    public class EquiIndexTests
    {

        int[] _emptyArr;
        int[] _oneEleArr;
        int[] _noequiArr;
        int[] _3and6Arr;


        [TestInitialize]
        public void Setup()
        {
            _emptyArr = new int[0];
            _oneEleArr = new int[1] { 1 };
            _noequiArr = new int[] { 1, 2, 3, 4 };
            _3and6Arr = new int[7] { -7, 1, 5, 2, -4, 3, 0 };
        }

        //[TestMethod]
        //public void equi_emptyArray_returnszero()
        //{
        //    var result = EquiIndex.Class1.Equi(_emptyArr);
        //    Assert.AreEqual(0, result);
        //}
        //[TestMethod]
        //public void equi_noequiarr_returnsminus1()
        //{
        //    var result = EquiIndex.Class1.Equi(_noequiArr);
        //    Assert.AreEqual(-1, result);
        //}
        //[TestMethod]
        //public void equi_testoneelearr_returnsminus1()
        //{
        //    var result = EquiIndex.Class1.Equi(_oneEleArr);
        //    Assert.AreEqual(-1, result);
        //}
        //[TestMethod]
        //public void equi_test3and6arr_returns3()
        //{
        //    var result = EquiIndex.Class1.Equi(_3and6Arr);
        //    Assert.AreEqual(3, result);
        //}
    }
}
