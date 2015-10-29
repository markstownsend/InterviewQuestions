using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TwoSum;
using System;

namespace All.Tests
{
    [TestClass]
    public class TwoSumTests
    {
        List<int> _full;
        List<int> _short;
        List<int> _negative;

        [TestInitialize]
        public void Setup()
        {
            _short = new List<int>() { 1, 2, 3 };
            _full = new List<int>() { 1, 3, 5, 7, 9 };
            _negative = new List<int>() { -1, 4, -5, 6 };
        }

        [TestMethod]
        public void findtwosum_emptylist_returnsnull()
        {
            var result = Class1.FindTwoSum(null,13);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void findtwosum_fulllist_returnstuple()
        {
            var result = Class1.FindTwoSum(_full, 12);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void findtwosum_fulllist_returnsvalidtuple()
        {
            var result = Class1.FindTwoSum(_full, 12);
            Assert.AreNotEqual(-1, result.Item1); 
        }
        [TestMethod]
        public void findtwosum_fulllist_returns4and1()
        {
            var result = Class1.FindTwoSum(_full, 12);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(4, result.Item2);
        }
        [TestMethod]
        public void findtwosum_fulllist_returns2and3()
        {
            var result = Class1.FindTwoSum(_negative, 10);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(3, result.Item2);
        }
        [TestMethod]
        public void findtwosum_fulllist_returns0and2()
        {
            var result = Class1.FindTwoSum(_negative, -6);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }
    }
}
