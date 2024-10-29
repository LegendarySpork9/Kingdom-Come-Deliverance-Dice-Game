using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Game_Text
    {
        // Stores the text for the game.
        // Settings
        public static string Settings = $@"//=============================\\
||          Settings:          ||
||                             ||
||         Players: {Game_Data.NumberOfPlayers}          ||   Up Arrow, Down Arrow - Navigate Settings
||         Score: {Game_Data.TargetScore}         ||   <- -> - Alter Values
||                             ||
||   Press Enter to Continue   ||
\\=============================//";

        // Player 1
        public static string P1Roll = @"   //=============================\\
   ||                             ||
   ||                             ||   E - Hold Die
   ||       {0}      {1}      {2}       ||   F - Score and Roll Again
   ||                             ||   Q - Pass
   ||       {3}      {4}      {5}       ||   1 -> 6 - Choose Die
   ||                             ||   Esc - Quit Game
   ||                             ||
   \\=============================//";

        // Score
        public static string Score = @"//===================================\\
||    Player 1:    |    Player 2:    ||
||  Total/{0}     |  Total/{1}     ||
||  Pot:           |  Pot:           ||
||  Round:         |  Round:         ||
||  Selected:      |  Selected:      ||
\\===================================//";

        // Current Game Text.
        public static string Text = Settings;

        // Settings Positions.
        public static (int, int) GetSettingPosition(int Setting)
        {
            return Setting switch
            {
                1 => (115, 126),
                2 => (193, 205),
                _ => (0, 0)
            };
        }

        // Dice Positions.
        public static (int, int) GetDicePosition(int Dice)
        {
            return Dice switch
            {
                1 => (140, 142),
                2 => (147, 149),
                3 => (154, 156),
                4 => (254, 256),
                5 => (261, 263),
                6 => (268, 270),
                _ => (0, 0)
            };
        }

        // Score Positions.
        public static int GetScorePosition(int Stat)
        {
            return Stat switch
            {
                1 => 130,
                2 => 173,
                3 => 217,
                4 => 148,
                5 => 191,
                6 => 235,
                _ => 0,
            };
        }
    }
}
