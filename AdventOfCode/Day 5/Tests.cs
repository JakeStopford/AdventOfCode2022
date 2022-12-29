using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day5
{
    public class Tests
    {
        [Test]
        public void GetTopCrates()
        {
            var result = Solution5.GetTopCranes();

            result.Should().Be("QNNTGTPFN");
        }
    }
}