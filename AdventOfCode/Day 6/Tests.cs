using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day6
{
    public class Tests
    {
        [Test]
        public void GetTopCrates()
        {
            var result = Solution6.FindStartOfPacketMarker();

            result.Should().Be(1912);
        }
    }
}