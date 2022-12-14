using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day4
{
    public class Tests
    {
        [Test]
        public void TestCompleteOverlap()
        {
            var actual = Solution4.GetTotalContainedPairs();

            actual.Should().Be(509);
        }
        
        [Test]
        public void TestAnyOverlap()
        {
            var actual = Solution4.GetTotalOverlappingPairs();

            actual.Should().Be(870);
        }
    }
}