using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day5
{
    public class Tests
    {
        [Test]
        public void GetTopCrates()
        {
            var result = Solution5.GetTopCrates();

            result.Should().Be("QNNTGTPFN");
        }
        
        [Test]
        public void GetTopCratesCrane9001()
        {
            var result = Solution5.GetTopCrates9001();

            result.Should().Be("GGNPJBTTR");
        }
    }
}