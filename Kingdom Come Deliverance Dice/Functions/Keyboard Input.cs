// Copyright © - unpublished - Toby Hunter
namespace Kingdom_Come_Deliverance_Dice.Functions
{
    internal class KeyboardInput
    {
        public void MenuInput(ConsoleKey Key)
        {
            
        }

        // Retained from the original code
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

        // GameInput method with original functionality
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
