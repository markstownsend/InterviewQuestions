using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Run;

namespace All.Tests
{
    [TestClass]
    public class RunTests
    {
        [TestMethod]
        public void IndexOfLongestRun_fouras_returnszero()
        {
            int index = Run.Run.IndexOfLongestRun("aaaa");
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void IndexOfLongestRun_abbcccddddcccbba_returnssiz()
        {
            int index = Run.Run.IndexOfLongestRun("abbcccddddcccbba");
            Assert.AreEqual(6, index);
        }
        [TestMethod]
        public void IndexOfLongestRun_aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa_returnszero()
        {
            int index = Run.Run.IndexOfLongestRun("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual(0, index);
        }
        [TestMethod]
        public void IndexOfLongestRun_abcdefghijk_returnszero()
        {
            int index = Run.Run.IndexOfLongestRun("abcdefghijk");
            Assert.AreEqual(0, index);
        }
        [TestMethod]
        public void IndexOfLongestRun_k_returnszero()
        {
            int index = Run.Run.IndexOfLongestRun("k");
            Assert.AreEqual(0, index);
        }
        [TestMethod]
        public void IndexOfLongestRun_emptystring_returnszero()
        {
            int index = Run.Run.IndexOfLongestRun("");
            Assert.AreEqual(0, index);
        }
        [TestMethod]
        public void IndexOfLongestRun_abb_returnsone()
        {
            int index = Run.Run.IndexOfLongestRun("abb");
            Assert.AreEqual(1, index);
        }
    }
}
