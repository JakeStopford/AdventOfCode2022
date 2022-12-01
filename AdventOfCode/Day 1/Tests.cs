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
            Assert.AreEqual(66616, totalCalories);
        }
        
        [Test]
        public void TestTop3Calories()
        {
            // Act
            var totalCalories = Solution.FindTop3Calories();

            // Assert
            Assert.AreEqual(199172, totalCalories);
        }
    }
}