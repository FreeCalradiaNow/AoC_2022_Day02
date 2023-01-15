using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2022_Day02
{
    public class Round
    {
        public static int OpponentChoicePoints { get; set; }
        public static int OpponentOutcomePoints { get; set; }
        public static int PlayerChoicePoints { get; set; }
        public static int PlayerOutcomePoints { get; set; }
        public Round(int opponentChoicePoints, int opponentOutcomePoints, int playerChoicePoints, int playerOutcomePoints)
        {
            Round.OpponentChoicePoints = opponentChoicePoints;
            Round.OpponentOutcomePoints = opponentOutcomePoints;
            Round.PlayerChoicePoints = playerChoicePoints;
            Round.PlayerOutcomePoints = playerOutcomePoints;
        }

    }
}
