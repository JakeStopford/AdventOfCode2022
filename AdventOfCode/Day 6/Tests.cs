using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day6
{
    public class Tests
    {
        [Test]
        public void GetStartOfPacketMarker()
        {
            var result = Solution6.FindStartOfPacketMarker();

            result.Should().Be(1912);
        }
        
        [Test]
        public void GetStartOfMessageMarker()
        {
            var result = Solution6.FindStartOfMessageMarker();

            result.Should().Be(2122);
        }
    }
}