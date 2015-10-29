using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TapeEquilibrium;
using System;

namespace All.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void solution_examplearray_returnsthree()
        {
            var result = Solution.solution(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void solution_oppositepairarray_returnszero()
        {
            var result = Solution.solution(new int[] { 1000, -1000 });
            Assert.AreEqual(0, result);
        }
    }
}
