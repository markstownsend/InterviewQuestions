using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AddDigits;
using System;

namespace All.Tests
{
    [TestClass]
    public class AddDigitsTests
    {
        [TestMethod]
        public void adddigits_27_returnsnine()
        {
            var result = Solution.AddDigits(27);
            Assert.AreEqual(9, result);
        }
    }
}
