using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Day1
{
    public class Tests
    {
        [Test]
        public void TestMostCalories()
        {
            // Act
            var totalCalories = Solution.FindMostCalories();

            // Assert
            totalCalories.Should().Be(66616);
        }
        
        [Test]
        public void TestTop3Calories()
        {
            // Act
            var totalCalories = Solution.FindTop3Calories();

            // Assert
            totalCalories.Should().Be(199172);
        }
    }
}