namespace AdventOfCode.Day4
{
    public static class Solution4
    {
        private static string[] backpacks =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day4.txt");

        public static int GetTotalContainedPairs()
        {
            var total = 0;

            var pairs = backpacks.Select(x => x.Split(","));
            var numbers = pairs.Select(x => x.Select(y => y.Split("-"))).ToList();

            for (var i = 0; i < numbers.Count(); i++)
            {
                var low = numbers.Select(x => x.Select(y => y[0])).ElementAt(i);
                var high = numbers.Select(x => x.Select(y => y[1])).ElementAt(i);
                
                if (int.Parse(low.First()) >= int.Parse(low.Last()) && int.Parse(high.First()) <= int.Parse(high.Last()))
                {
                    total++;
                }
                else if (int.Parse(low.First()) <= int.Parse(low.Last()) && int.Parse(high.First()) >= int.Parse(high.Last()))
                {
                    total++;
                }
            }
            return total;
        }
    }
}