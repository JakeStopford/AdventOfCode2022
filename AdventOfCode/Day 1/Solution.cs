namespace AdventOfCode
{
    public static class Solution
    {
        private static string[] numbers =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day1.txt");

        public static int FindMostCalories()
        {
            var elfCalories = new List<int>();
            var runningTotal = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case "":
                        elfCalories.Add(runningTotal);
                        runningTotal = 0;
                        break;
                    default:
                        runningTotal += int.Parse(numbers[i]);
                        break;
                }
            }
            return elfCalories.Max();
        }

        public static int FindTop3Calories()
        {
            var elfCalories = new List<int>();
            var runningTotal = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case "":
                        elfCalories.Add(runningTotal);
                        runningTotal = 0;
                        break;
                    default:
                        runningTotal += int.Parse(numbers[i]);
                        break;
                }
            }
            return elfCalories.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}