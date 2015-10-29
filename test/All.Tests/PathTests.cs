using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Path;

namespace All.Tests
{
    [TestClass]
    public class PathTests
    {
        [TestMethod]
        public void Path_Root_ReturnsRoot()
        {
            Pathc path = new Pathc("/");
            Assert.AreEqual("/", path.CurrentPath);
        }
        [TestMethod]
        public void Cd_WithRoot_ReturnsRoot()
        {
            Pathc path = new Pathc("/");
            path.Cd("/");
            Assert.AreEqual("/", path.CurrentPath);
        }

        [TestMethod]
        public void Cd_WithComplexPath_ReturnsComplexPath()
        {
            Pathc path = new Pathc("/a/b/c/d");
            path.Cd("..");
            Assert.AreEqual("/a/b/c", path.CurrentPath);
        }
    }
}
