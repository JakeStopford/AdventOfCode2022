using NUnit.Framework;

namespace AdventOfCode.Day2
{
    public class Tests
    {
        [Test]
        public void TestTotalScore()
        {
            Solution2.GetTotalScore();
        }
        
        [Test]
        public void TestNewStrategyTotalScore()
        {
            Solution2.GetNewTotalScore();
        }
    }
}