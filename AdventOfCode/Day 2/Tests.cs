using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day2
{
    public class Tests
    {
        [Test]
        public void TestTotalScore()
        {
            var actual = Solution2.GetTotalScore();

            actual.Should().Be(11449);
        }

        [Test]
        public void TestNewStrategyTotalScore()
        {
            var actual = Solution2.GetNewTotalScore();

            actual.Should().Be(13187);
        }
    }
}