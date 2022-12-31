namespace AdventOfCode.Day6
{
    public static class Solution6
    {
        private static string datastream = File.ReadAllText(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day6.txt");

        public static int FindStartOfPacketMarker()
        {
            var i = 0;
            for (i = 3; i < datastream.Length; i++)
            {
                var arr = datastream.Substring(i - 3, 4).ToCharArray();
                if (arr.Select(x => x).Distinct().Count() == 4)
                {
                    break;
                }
            }

            return i + 1;
        }

        public static int FindStartOfMessageMarker()
        {
            var i = 0;
            for (i = 13; i < datastream.Length; i++)
            {
                var arr = datastream.Substring(i - 13, 14).ToCharArray();
                if (arr.Select(x => x).Distinct().Count() == 14)
                {
                    break;
                }
            }

            return i + 1;
        }
    }
}