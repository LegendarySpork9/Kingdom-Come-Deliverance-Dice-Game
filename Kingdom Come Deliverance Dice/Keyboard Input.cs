using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Keyboard_Input
    {
        // Captures the input and returns the action.
        public static void Input(ConsoleKey Key)
        {
            switch (Key)
            {
                case ConsoleKey.Enter: Settings.ShowSettings(); break;
            }
        }

        public static void SettingsInput(ConsoleKey Key)
        {
            switch (Key)
            {
                //case ConsoleKey.UpArrow: Settings.SelectSetting(Settings_Model.SettingSelected - 1); break;
                //case ConsoleKey.DownArrow: Settings.SelectSetting(Settings_Model.SettingSelected + 1); break;
                //case ConsoleKey.LeftArrow: Settings.SettingValue(Settings_Model.SettingSelected, "Left"); break;
                //case ConsoleKey.RightArrow: Settings.SettingValue(Settings_Model.SettingSelected, "Right"); break;
                case ConsoleKey.Enter: Game.PlayGame(); break;
            }
        }

        public static void GameInput(ConsoleKey Key)
        {
            switch (Key)
            {
                case ConsoleKey.Escape: Environment.Exit(0); break;
                case ConsoleKey.D1: Game.IsHeld(1); break;
                case ConsoleKey.D2: Game.IsHeld(2); break;
                case ConsoleKey.D3: Game.IsHeld(3); break;
                case ConsoleKey.D4: Game.IsHeld(4); break;
                case ConsoleKey.D5: Game.IsHeld(5); break;
                case ConsoleKey.D6: Game.IsHeld(6); break;
                case ConsoleKey.E: Game.HoldDiceCheck(); break;
                case ConsoleKey.F: Game.ScoreAndRoll(); break;
            }
        }
    }
}
