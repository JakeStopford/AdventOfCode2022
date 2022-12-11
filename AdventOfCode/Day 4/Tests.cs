using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day4
{
    public class Tests
    {
        [Test]
        public void TestTotalScore()
        {
            var actual = Solution4.GetTotalContainedPairs();

            actual.Should().Be(509);
        }
    }
}