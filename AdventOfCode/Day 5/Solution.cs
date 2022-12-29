namespace AdventOfCode.Day5
{
    public static class Solution5
    {
        private static string[] cranes = File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day5.txt");
        private static List<Instruction> instructionList = new List<Instruction>();

        private static List<char> list1 = new List<char> { 'F', 'D', 'B', 'Z', 'T', 'J', 'R', 'N' };
        private static List<char> list2 = new List<char> { 'R', 'S', 'N', 'J', 'H' };
        private static List<char> list3 = new List<char> { 'C', 'R', 'N', 'J', 'G', 'Z', 'F', 'Q' };
        private static List<char> list4 = new List<char> { 'F', 'V', 'N', 'G', 'R', 'T', 'Q' };
        private static List<char> list5 = new List<char> { 'L', 'T', 'Q', 'F' };
        private static List<char> list6 = new List<char> { 'Q', 'C', 'W', 'Z', 'B', 'R', 'G', 'N' };
        private static List<char> list7 = new List<char> { 'F', 'C', 'L', 'S', 'N', 'H', 'M' };
        private static List<char> list8 = new List<char> { 'D', 'N', 'Q', 'M', 'T', 'J' };
        private static List<char> list9 = new List<char> { 'P', 'G', 'S' };

        private static Dictionary<string, List<char>> lists = new()
        {
            { "list1", list1},
            { "list2", list2},
            { "list3", list3},
            { "list4", list4},
            { "list5", list5},
            { "list6", list6},
            { "list7", list7},
            { "list8", list8},
            { "list9", list9},
        };

        public static string GetTopCranes()
        {
            var arrays = cranes.TakeWhile(x => x != "");
            var instructions = cranes.Skip(arrays.Count() + 1).ToList();

            BuildInstructionList(instructions);

            for (var i = 0; i < instructions.Count; i++)
            {
                var origin = instructionList[i].Origin;
                var numberToMove = instructionList[i].NumberToMove;
                var destination = instructionList[i].Destination;

                var itemsToMove = lists["list" + origin].TakeLast(numberToMove).Reverse();
                lists["list" + destination].InsertRange(lists["list" + destination].Count, itemsToMove);
                lists["list" + origin].RemoveRange(lists["list" + origin].Count - itemsToMove.Count(), itemsToMove.Count());
            }

            return $"{list1[list1.Count - 1]}{list2[list2.Count - 1]}{list3[list3.Count - 1]}{list4[list4.Count - 1]}{list5[list5.Count - 1]}" +
                   $"{list6[list6.Count - 1]}{list7[list7.Count - 1]}{list8[list8.Count - 1]}{list9[list9.Count - 1]}";
        }

        private static void BuildInstructionList(List<string> instructions)
        {
            for (var i = 0; i < instructions.Count(); i++)
            {
                instructionList.Add(new Instruction
                {
                    NumberToMove = int.Parse(instructions[i].Split(" ")[1]),
                    Origin = int.Parse(instructions[i].Split(" ")[3]),
                    Destination = int.Parse(instructions[i].Split(" ")[5])
                });
            }
        }
    }

    public class Instruction
    {
        public int NumberToMove { get; set; }
        public int Origin { get; set; }
        public int Destination { get; set; }
    }
}