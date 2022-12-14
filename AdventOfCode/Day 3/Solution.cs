namespace AdventOfCode.Day3
{
    public static class Solution3
    {
        private static string[] backpacks =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day3.txt");

        private static Dictionary<char, int> itemScores = new()
        {
            { 'a', 1},
            { 'b', 2},
            { 'c', 3},
            { 'd', 4},
            { 'e', 5},
            { 'f', 6},
            { 'g', 7},
            { 'h', 8},
            { 'i', 9},
            { 'j', 10},
            { 'k', 11},
            { 'l', 12},
            { 'm', 13},
            { 'n', 14},
            { 'o', 15},
            { 'p', 16},
            { 'q', 17},
            { 'r', 18},
            { 's', 19},
            { 't', 20},
            { 'u', 21},
            { 'v', 22},
            { 'w', 23},
            { 'x', 24},
            { 'y', 25},
            { 'z', 26},
            { 'A', 27},
            { 'B', 28},
            { 'C', 29},
            { 'D', 30},
            { 'E', 31},
            { 'F', 32},
            { 'G', 33},
            { 'H', 34},
            { 'I', 35},
            { 'J', 36},
            { 'K', 37},
            { 'L', 38},
            { 'M', 39},
            { 'N', 40},
            { 'O', 41},
            { 'P', 42},
            { 'Q', 43},
            { 'R', 44},
            { 'S', 45},
            { 'T', 46},
            { 'U', 47},
            { 'V', 48},
            { 'W', 49},
            { 'X', 50},
            { 'Y', 51},
            { 'Z', 52},
        };
        public static int GetTotalItemScore()
        {
            char[] arr = new char[backpacks.Length];

            for (int i = 0; i < backpacks.Length; i++)
            {
                var common = backpacks[i].Substring(0, backpacks[i].Length / 2).ToCharArray()
                    .First(x => backpacks[i].Substring(backpacks[i].Length / 2, backpacks[i].Length / 2)
                        .Contains(x));
                arr[i] = common;
            }

            return arr.Select(x => itemScores[x]).Sum();
        }

        public static int GetTotalBadgeScore()
        {
            char[] arr = new char[backpacks.Length / 3];

            for (int i = 0; i < backpacks.Length; i+=3)
            {
                var common = backpacks[i].ToCharArray()
                    .First(x => backpacks[i+1].Contains(x) && backpacks[i+2].Contains(x));
                arr[i/3] = common;
            }
            return arr.Select(x => itemScores[x]).Sum();
        }
    }
}