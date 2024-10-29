using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Game_Data
    {
        // Stores the data for the game.
        // Game Settings
        public static int NumberOfPlayers = 1;
        public static int TargetScore = 4000;
        public static int Player = 1;

        // General
        public static int Round { get; set; } = 0;
        public static int PreviousRound { get; set; } = 0;
        public static int Selected { get; set; } = 0;
        public static int PreviousSelected { get; set; } = 0;
        public static Dictionary<int, int> CombosAchieved { get; set; } = new();
        public static int BeforeStraight { get; set; } = 0;
        public static bool StraightAchieved { get; set; } = false;

        // Player 1
        public static bool P1D1Selected { get; set; } = false;
        public static bool P1D2Selected { get; set; } = false;
        public static bool P1D3Selected { get; set; } = false;
        public static bool P1D4Selected { get; set; } = false;
        public static bool P1D5Selected { get; set; } = false;
        public static bool P1D6Selected { get; set; } = false;
        public static int P1Pot { get; set; } = 0;
        public static int[] P1HeldDice { get; set; } = Array.Empty<int>();
        public static bool P1Bust { get; set; } = false;
    }
}
