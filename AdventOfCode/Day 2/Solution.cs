namespace AdventOfCode
{
    public static class Solution2
    {
        private static string[] turns =
            System.IO.File.ReadAllLines(@"C:\source\repos\AdventOfCode2023\AdventOfCode\Resources\Day2.txt");

        private static int totalScore = 0;

        public static int GetTotalScore()
        {
            totalScore = 0;
            for (int i = 0; i < turns.Length; i++)
            {
                var elfHand = turns[i].Split(" ")[0];
                var myHand = turns[i].Split(" ")[1];

                switch (elfHand)
                {
                    case "A":
                        if (myHand == "X")
                            totalScore += 4;
                        if (myHand == "Y")
                            totalScore += 8;
                        if (myHand == "Z")
                            totalScore += 3;
                        break;
                    case "B":
                        if (myHand == "X")
                            totalScore += 1;
                        if (myHand == "Y")
                            totalScore += 5;
                        if (myHand == "Z")
                            totalScore += 9;
                        break;
                    default:
                        if (myHand == "X")
                            totalScore += 7;
                        if (myHand == "Y")
                            totalScore += 2;
                        if (myHand == "Z")
                            totalScore += 6;
                        break;
                }
            }
            return totalScore;
        }

        public static int GetNewTotalScore()
        {
            totalScore = 0;
            for (int i = 0; i < turns.Length; i++)
            {
                var elfHand = turns[i].Split(" ")[0];
                var myResult = turns[i].Split(" ")[1];

                switch (elfHand)
                {
                    case "A": //rock
                        if (myResult == "X")
                            totalScore += 3;
                        if (myResult == "Y")
                            totalScore += 4;
                        if (myResult == "Z")
                            totalScore += 8;
                        break;
                    case "B": //paper
                        if (myResult == "X")
                            totalScore += 1;
                        if (myResult == "Y")
                            totalScore += 5;
                        if (myResult == "Z")
                            totalScore += 9;
                        break;
                    default: //scissors
                        if (myResult == "X")
                            totalScore += 2;
                        if (myResult == "Y")
                            totalScore += 6;
                        if (myResult == "Z")
                            totalScore += 7;
                        break;
                }
            }
            return totalScore;
        }
    }
}