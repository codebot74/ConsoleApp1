using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Calculating score before 10 Frame
            Bowling bowlingScore = new Bowling();
            bowlingScore.CalculateScore();
            var expected = 0;
            Assert.AreEqual(expected, bowlingScore.Score);           
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bowling bowlingScore = new Bowling();
            bowlingScore.CalculateScore();
            bowlingScore.RegisterThrows(10); 
            bowlingScore.RegisterThrows(10); 
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10, 10, 10);
            bowlingScore.CalculateScore();
            var expected = 300;
            Assert.AreEqual(expected, bowlingScore.Score);
        }
    }
}