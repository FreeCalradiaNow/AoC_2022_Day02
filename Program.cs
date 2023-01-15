using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC_2022_Day02
{
    class Program
    {
        public const string FilePath = @"C:\ZZZ MW Daten\AoC_2022Day2LiveInput.txt";

        //public static List<int> PointsOpponent = new List<int>();
        //public static List<int> PointsPlayer = new List<int>();
        //public static List<int> WinsOpponent = new List<int>();
        //public static List<int> Draws = new List<int>();
        public static List<Round> Turnier = new();
        

        public static int CountedRounds;
        public static int TotalOpponentPoints;
        public static int TotalPlayerPoints;
        public static int TotalOpponentWins;
        public static int TotalPlayerWins;
        public static int TotalDraws;

        public static string WinnerOfTournament;

        public static string PartChoice;

        //public static int TotalOpponentPoints = new();
        //public static int TotalPlayerPoints = new();
        static void Main(string[] args)
        {
            var Input = File.ReadAllText(FilePath)
            .Split("\r\n", StringSplitOptions.None)
            .Select(round => round.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray()
            )
            .ToArray();
            
            var Output = Input; //.Select(round => round.

        Starting:
            Console.WriteLine("Bitte Tasteneingabe für Part 1 oder Part 2..");
            PartChoice = Console.ReadLine();
            if (PartChoice == "1")
            {
                goto Part1;

            }
            if (PartChoice == "2")
            {
                goto Part2;
            }
            else
            {
                goto Starting;
            }


        Part1:
            foreach (string[] round in Output)
            {
               
                Round _Round = new Round(0, 0, 0, 0);

                if (round[0] == "A")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints ++;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints ++;
                        Round.PlayerOutcomePoints += 3;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints ++;
                        Round.PlayerChoicePoints += 2;
                        Round.PlayerOutcomePoints += 6;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints ++;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints += 3;
                    }
                }
                if (round[0] == "B")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints ++;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints += 2;
                        Round.PlayerOutcomePoints += 3;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.PlayerChoicePoints += 3;
                        Round.PlayerOutcomePoints += 6;
                    }
                }
                if (round[0] == "C")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.PlayerChoicePoints ++;
                        Round.PlayerOutcomePoints += 6;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints += 2;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints += 3;
                        Round.PlayerOutcomePoints += 3;
                    }
                }
                Turnier.Add(_Round);

                
                if (Round.OpponentOutcomePoints > Round.PlayerOutcomePoints)
                {
                    TotalOpponentWins++;
                }
                if (Round.OpponentOutcomePoints < Round.PlayerOutcomePoints)
                {
                    TotalPlayerWins++;
                }
                if (Round.OpponentOutcomePoints == Round.PlayerOutcomePoints)
                {
                    TotalDraws++;
                }

                TotalOpponentPoints += (Round.OpponentChoicePoints + Round.OpponentOutcomePoints);
                TotalPlayerPoints += (Round.PlayerChoicePoints + Round.PlayerOutcomePoints);
                CountedRounds++;
              
                
            }

        Endregion:
            if (TotalOpponentPoints > TotalPlayerPoints)
            {
                WinnerOfTournament = "der Gegener ";
            }
            if (TotalOpponentPoints < TotalPlayerPoints)
            {
                WinnerOfTournament = "der Spieler ";
            }
            else
            {
                WinnerOfTournament = "niemand ";
            }

            Console.WriteLine("Es wurden >" + CountedRounds + "< Runden gespielt.\n" +
                "Der Gegner hat davon " + TotalOpponentWins + " Runden gewonnen.\n" +
                TotalPlayerWins + " Runden hat der Spieler gewonnen.\n" + 
                TotalDraws + " Runden endeten unentschieden.\n\n" + 
                "Der Gegner hat insgesamt " + TotalOpponentPoints + " Punkte erzielt.\n" + 
                "Der Spieler erzielte " + TotalPlayerPoints + " Punkte.\n\n" + 
                "Somit hat " + WinnerOfTournament + " das Turnier gewonnen!");
            Console.WriteLine("");
            Console.ReadLine();
            goto End;

        Part2:
            foreach (string[] round in Output)
            {

                Round _Round = new Round(0, 0, 0, 0);

                if (round[0] == "A")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints++;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints += 3;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints++;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints++;
                        Round.PlayerOutcomePoints += 3;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints++;
                        Round.PlayerChoicePoints += 2;
                        Round.PlayerOutcomePoints += 6;
                    }
                }
                if (round[0] == "B")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints++;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints += 2;
                        Round.PlayerOutcomePoints += 3;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints += 2;
                        Round.PlayerChoicePoints += 3;
                        Round.PlayerOutcomePoints += 6;
                    }
                }
                if (round[0] == "C")
                {
                    if (round[1] == "X")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.OpponentOutcomePoints += 6;
                        Round.PlayerChoicePoints += 2;
                    }
                    if (round[1] == "Y")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.OpponentOutcomePoints += 3;
                        Round.PlayerChoicePoints += 3;
                        Round.PlayerOutcomePoints += 3;
                    }
                    if (round[1] == "Z")
                    {
                        Round.OpponentChoicePoints += 3;
                        Round.PlayerChoicePoints++;
                        Round.PlayerOutcomePoints += 6;
                    }
                }

                if (Round.OpponentOutcomePoints > Round.PlayerOutcomePoints)
                {
                    TotalOpponentWins++;
                }
                if (Round.OpponentOutcomePoints < Round.PlayerOutcomePoints)
                {
                    TotalPlayerWins++;
                }
                if (Round.OpponentOutcomePoints == Round.PlayerOutcomePoints)
                {
                    TotalDraws++;
                }

                TotalOpponentPoints += (Round.OpponentChoicePoints + Round.OpponentOutcomePoints);
                TotalPlayerPoints += (Round.PlayerChoicePoints + Round.PlayerOutcomePoints);
                CountedRounds++;
            }






                goto Endregion;

            End:
            Console.Clear();
            Console.WriteLine("Zum Verlassen bitte beliebige Taste drücken.");
            Console.ReadKey();
            //Turnier.ForEach((Round.OpponentPoints) => TotalOpponentPoints += Round.OpponentPoints);
            //{
            //
            //}

        }
    }
}
