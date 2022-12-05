using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day3
{
    public class Tests
    {
        [Test]
        public void TestTotalScore()
        {
            var actual = Solution3.GetTotalItemScore();

            actual.Should().Be(7795);
        }
        
        [Test]
        public void TestBadgeTotalScore()
        {
            var actual = Solution3.GetTotalBadgeScore();

            actual.Should().Be(2703);
        }
    }
}