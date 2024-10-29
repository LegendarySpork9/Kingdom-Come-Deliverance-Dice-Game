using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Settings_Model
    {
        public static int SettingSelected { get; set; } = 0;
        public static int PlayerNumbers { get; set; } = 1;
        public static int TargetScore { get; set; } = 4;

        public static void Players(int NOPlayers)
        {
            Game_Data.NumberOfPlayers = NOPlayers switch
            {
                1 => 1,
                2 => 2,
                _ => 1
            };
        }

        public static void Score(int TargetScore)
        {
            Game_Data.TargetScore = TargetScore switch
            {
                1 => 1000,
                2 => 2000,
                3 => 3000,
                4 => 4000,
                5 => 5000,
                6 => 6000,
                7 => 7000,
                8 => 8000,
                9 => 9000,
                _ => 4000
            };
        }

        public static void ValidateSettingNumber(int Setting)
        {
            SettingSelected = Setting switch
            {
                0 => 2,
                1 => 1,
                2 => 2,
                3 => 1,
                _ => 1
            };
        }

        public static void ValidatePlayerNumber(int Players)
        {
            PlayerNumbers = Players switch
            {
                0 => 2,
                1 => 1,
                2 => 2,
                3 => 1,
                _ => 1
            };
        }

        public static void ValidateScoreNumber(int Score)
        {
            TargetScore = Score switch
            {
                0 => 9,
                1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 8,
                9 => 9,
                10 => 1,
                _ => 1
            };
        }
    }
}
