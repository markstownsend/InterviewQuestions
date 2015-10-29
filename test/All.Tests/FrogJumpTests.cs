using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrogJump;

namespace All.Tests
{
    [TestClass]
    public class FrogJumpTests
    {
        [TestMethod]
        public void solution_tentwenty5_Returnstwo()
        {
            var result = Solution.solution(10,20,5);
            Assert.AreEqual(2, result);
        }
    }
}
