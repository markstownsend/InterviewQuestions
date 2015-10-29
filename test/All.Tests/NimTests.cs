using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Nim;

namespace All.Tests
{
    [TestClass]
    public class NimTests
    {
        [TestMethod]
        public void CanWinNim_one_returnstrue()
        {
            var result = Class1.CanWinNim(1);
            Assert.AreEqual(true, result);
        }
    }
}
