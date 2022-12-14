namespace AdventOfCode.Day4
{
    public static class Solution4
    {
        private static string[] pairs =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day4.txt");

        public static int GetTotalContainedPairs()
        {
            var total = 0;

            var pairs = Solution4.pairs.Select(x => x.Split(","));
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

        public static int GetTotalOverlappingPairs()
        {
            var total = 0;

            var pairs = Solution4.pairs.Select(x => x.Split(","));
            var numbers = pairs.Select(x => x.Select(y => y.Split("-"))).ToList();

            for (var i = 0; i < numbers.Count(); i++)
            {
                var low = numbers.Select(x => x.Select(y => y[0])).ElementAt(i);
                var high = numbers.Select(x => x.Select(y => y[1])).ElementAt(i);

                for (var x = int.Parse(low.First()); x <= int.Parse(high.First()); x++)
                {
                    if (x >= int.Parse(low.Last()) && x <= int.Parse(high.Last()))
                    {
                        total++;
                        break;
                    }
                }
            }
            return total;
        }
    }
}