namespace AdventOfCode
{
    public static class Solution
    {
        private static string[] numbers =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Data.txt");

        public static int FindMostCalories()
        {
            var totalCalories = 0;
            var runningTotal = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case "":
                        if (runningTotal >= totalCalories)
                        {
                            totalCalories = runningTotal;
                        }
                        runningTotal = 0;
                        break;
                    default:
                        runningTotal += int.Parse(numbers[i]);
                        break;
                }
            }
            return totalCalories;
        }

        public static int FindTop3Calories()
        {
            var runningTotal = 0;

            List<int> elfCalories = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
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
            elfCalories.Sort();
            return elfCalories.TakeLast(3).Sum();
        }
    }
}