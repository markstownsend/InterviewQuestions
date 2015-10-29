using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GroupAnagrams;

namespace All.Tests
{
    [TestClass]
    public class GroupAnagramsTests
    {
        [TestMethod]
        public void GroupAnagrams_emptylist_returnsempty()
        {
            string[] arr = new string[] { "bin", "nib", "ibn", "ate", "eat", "forthright", "thgirhtrof", "banana" };
            var result = Class1.GroupAnagrams(arr);
            Assert.AreEqual(4, result.Count);
        }
    }
}
