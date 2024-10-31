namespace Kingdom_Come_Deliverance_Dice
{
    internal class Settings
    {
        // Shows the settings screen.
        public static void ShowSettings()
        {
            Console.Clear();
            //Console.WriteLine(Game_Text.Settings);

            while (true)
            {
                //Keyboard_Input.SettingsInput(Console.ReadKey().Key);
                Console.Clear();
                //Console.WriteLine(Game_Text.Text);
            }
        }

        // Selects the setting.
        public static void SelectSetting(int Setting)
        {
            //Settings_Model.ValidateSettingNumber(Setting);
            //var Positions = Game_Text.GetSettingPosition(Settings_Model.SettingSelected);

            //Game_Text.Text = Game_Text.Text.Replace("[", " ").Replace("]", " ");
            //Game_Text.Text = Game_Text.Text.Remove(Positions.Item1, 1).Insert(Positions.Item1, "[");
            //Game_Text.Text = Game_Text.Text.Remove(Positions.Item2, 1).Insert(Positions.Item2, "]");
        }

        // Gets the setting value.
        public static void SettingValue(int Setting, string Arrow)
        {
            if (Setting == 1)
            {
                switch (Arrow)
                {
                    case "Left": 
                        //Settings_Model.ValidatePlayerNumber(Settings_Model.PlayerNumbers - 1);
                        //Settings_Model.Players(Settings_Model.PlayerNumbers);
                        //UpdateSetting(Settings_Model.PlayerNumbers);
                        break;
                    case "Right":
                        //Settings_Model.ValidatePlayerNumber(Settings_Model.PlayerNumbers + 1);
                        //Settings_Model.Players(Settings_Model.PlayerNumbers);
                        //UpdateSetting(Settings_Model.PlayerNumbers);
                        break;
                }
            }

            else
            {
                switch (Arrow)
                {
                    case "Left":
                        //Settings_Model.ValidateScoreNumber(Settings_Model.TargetScore - 1);
                        //Settings_Model.Score(Settings_Model.TargetScore);
                        //UpdateSetting(Settings_Model.TargetScore);
                        break;
                    case "Right":
                        //Settings_Model.ValidateScoreNumber(Settings_Model.TargetScore + 1);
                        //Settings_Model.Score(Settings_Model.TargetScore);
                        //UpdateSetting(Settings_Model.TargetScore);
                        break;
                }
            }
        }

        // Updates the setting.
        public static void UpdateSetting(int value)
        {
            //var Positions = Game_Text.GetSettingPosition(Settings_Model.SettingSelected);

            //switch (Settings_Model.SettingSelected)
            //{
            //    case 1: 
            //        Settings_Model.Players(value);
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item2 - 1, 1).Insert(Positions.Item2 - 1, Game_Data.NumberOfPlayers.ToString());
            //        break;
            //    case 2:
            //        Settings_Model.Score(value);
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item2 - 4, 4).Insert(Positions.Item2 - 4, Game_Data.TargetScore.ToString());
            //        break;
            //}
        }
    }
}
