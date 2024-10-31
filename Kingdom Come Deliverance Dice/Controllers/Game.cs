using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Game
    {
        // Plays the game.
        public static void PlayGame()
        {
            //Dice_Roll.RollDice(1);
            //Game_Text.Text = string.Format(Game_Text.P1Roll, Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6);

            Console.Clear();
            //Console.WriteLine(Game_Text.Text);
            Console.WriteLine();
            //Console.WriteLine(string.Format(Game_Text.Score, Game_Data.TargetScore, Game_Data.TargetScore));

            Rules.IsBust();

            while (true)
            {
                Keyboard_Input.GameInput(Console.ReadKey().Key);
                Console.Clear();
                //Console.WriteLine(Game_Text.Text);
                Console.WriteLine();
                //Console.WriteLine(string.Format(Game_Text.Score, Game_Data.TargetScore, Game_Data.TargetScore));
            }
        }

        // Sorts which dice is to be selected.
        public static void ChooseDice(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    switch (Dice)
            //    {
            //        case 1: SelectDice(Dice, Game_Data.P1D1Selected); break;
            //        case 2: SelectDice(Dice, Game_Data.P1D2Selected); break;
            //        case 3: SelectDice(Dice, Game_Data.P1D3Selected); break;
            //        case 4: SelectDice(Dice, Game_Data.P1D4Selected); break;
            //        case 5: SelectDice(Dice, Game_Data.P1D5Selected); break;
            //        case 6: SelectDice(Dice, Game_Data.P1D6Selected); break;
            //    }
            //}
        }

        // Checks if the dice is held.
        public static void IsHeld(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    bool Held = false;
            //
            //    foreach (int Die in Game_Data.P1HeldDice)
            //    {
            //        if (Die == Dice)
            //        {
            //            Held = true;
            //        }
            //    }
            //
            //    if (!Held)
            //    {
            //        ChooseDice(Dice);
            //    }
            //}
        }

        // Checks if the dice can be held.
        public static void HoldDiceCheck()
        {
            //if (Game_Data.Player == 1)
            //{
            //    bool[] Selected = { Game_Data.P1D1Selected, Game_Data.P1D2Selected, Game_Data.P1D3Selected, Game_Data.P1D4Selected, Game_Data.P1D5Selected, Game_Data.P1D6Selected };
            //    int[] Rolls = { Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6 };
            //
            //    for (int x = 0; x < Selected.Length; x++)
            //    {
            //        if (Selected[x])
            //        {
            //            if (Rules.UsedInComboOrStraight(x + 1))
            //            {
            //                HoldDice(x + 1);
            //                Game_Data.P1HeldDice = Game_Data.P1HeldDice.Append(x + 1).ToArray();
            //                DeselectDice(x + 1);
            //            }
            //
            //            else if (Rolls[x] == 1 || Rolls[x] == 5)
            //            {
            //                HoldDice(x + 1);
            //                Game_Data.P1HeldDice = Game_Data.P1HeldDice.Append(x + 1).ToArray();
            //                Game_Data.Round += Game_Data.Selected;
            //                DeselectDice(x + 1);
            //            }
            //        }
            //    }
            //
            //    if (Game_Data.StraightAchieved)
            //    {
            //        Game_Data.Round += Game_Data.Selected;
            //    }
            //}

            UpdateScoreTable("Round");
        }

        // Checks if the dice is scored and rolls again if not.
        public static void ScoreAndRoll()
        {
            HoldDiceCheck();

            //if (Game_Data.Player == 1)
            //{
            //    for (int x = 0; x < 6; x++)
            //    {
            //        if (CanRoll(x + 1))
            //        {
            //            Dice_Roll.ReRollDice(x + 1);
            //        }
            //    }
            //
            //    Game_Text.Text = string.Format(Game_Text.P1Roll, Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6);
            //
            //    foreach (int Dice in Game_Data.P1HeldDice)
            //    {
            //        HoldDice(Dice);
            //    }
            //}

            Rules.IsBust();
            Rules.IsBoardCleared();
        }

        // Checks if the dice can be rolled again.
        private static bool CanRoll(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    foreach (int HeldDice in Game_Data.P1HeldDice)
            //    {
            //        if (Dice == HeldDice)
            //        {
            //            return false;
            //        }
            //    }
            //
            //    return true;
            //}

            return false;
        }

        // Holds the dice.
        private static void HoldDice(int Dice)
        {
            //var Positions = Game_Text.GetDicePosition(Dice);
            
            //Game_Text.Text = Game_Text.Text.Remove(Positions.Item1, 1).Insert(Positions.Item1, "|");
            //Game_Text.Text = Game_Text.Text.Remove(Positions.Item2, 1).Insert(Positions.Item2, "|");
        }

        // Deselectes the dice.
        private static void DeselectDice(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    switch (Dice)
            //    {
            //        case 1: Game_Data.P1D1Selected = false; break;
            //        case 2: Game_Data.P1D2Selected = false; break;
            //        case 3: Game_Data.P1D3Selected = false; break;
            //        case 4: Game_Data.P1D4Selected = false; break;
            //        case 5: Game_Data.P1D5Selected = false; break;
            //        case 6: Game_Data.P1D6Selected = false; break;
            //    }
            //}
        }

        // Selects the dice.
        private static void SelectDice(int Dice, bool Selected)
        {
            //var Positions = Game_Text.GetDicePosition(Dice);

            //switch (Selected)
            //{
            //    case true:
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item1, 1).Insert(Positions.Item1, " "); 
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item2, 1).Insert(Positions.Item2, " ");
            //        UpdateDiceData(Dice, false);
            //        break;
            //    case false:
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item1, 1).Insert(Positions.Item1, "[");
            //        Game_Text.Text = Game_Text.Text.Remove(Positions.Item2, 1).Insert(Positions.Item2, "]");
            //        UpdateDiceData(Dice, true);
            //        break;
            //}
        }

        // Updates the dice data.
        private static void UpdateDiceData(int Dice, bool Selected)
        {
            //if (Game_Data.Player == 1)
            //{
            //    switch (Dice)
            //    {
            //        case 1: Game_Data.P1D1Selected = Selected; Rules.SelectedPoints(1); break;
            //        case 2: Game_Data.P1D2Selected = Selected; Rules.SelectedPoints(2); break;
            //        case 3: Game_Data.P1D3Selected = Selected; Rules.SelectedPoints(3); break;
            //        case 4: Game_Data.P1D4Selected = Selected; Rules.SelectedPoints(4); break;
            //        case 5: Game_Data.P1D5Selected = Selected; Rules.SelectedPoints(5); break;
            //        case 6: Game_Data.P1D6Selected = Selected; Rules.SelectedPoints(6); break;
            //    }
            //}
        }

        // Updates the data table.
        public static void UpdateScoreTable(string Stat)
        {
            int StatPosition = 0;
            //int Length = Game_Data.PreviousSelected.ToString().Length;

            //if (Game_Data.Selected != 0)
            //{
            //    switch (Stat)
            //    {
            //        case "Selected":
            //            StatPosition = Game_Text.GetScorePosition(3);
            //            Game_Text.Score = Game_Text.Score.Remove(StatPosition, Length).Insert(StatPosition, Whitespace(Length));
            //            Game_Text.Score = Game_Text.Score.Remove(StatPosition, Game_Data.Selected.ToString().Length).Insert(StatPosition, Game_Data.Selected.ToString());
            //            break;
            //        case "Round":
            //            StatPosition = Game_Text.GetScorePosition(2);
            //            Game_Text.Score = Game_Text.Score.Remove(StatPosition, Game_Data.Round.ToString().Length).Insert(StatPosition, Game_Data.Round.ToString());
            //            StatPosition = Game_Text.GetScorePosition(3);
            //            Game_Text.Score = Game_Text.Score.Remove(StatPosition, Game_Data.Selected.ToString().Length).Insert(StatPosition, Whitespace(Game_Data.Selected.ToString().Length));
            //            Game_Data.Selected = 0;
            //            break;
            //    }
            //
            //    return;
            //}

            //StatPosition = Game_Text.GetScorePosition(3);
            //Game_Text.Score = Game_Text.Score.Remove(StatPosition, Length).Insert(StatPosition, Whitespace(Length));
        }

        // Returns the number of whitespace.
        private static string Whitespace(int Length)
        {
            return Length switch
            {
                1 => " ",
                2 => "  ",
                3 => "   ",
                4 => "    ",
                _ => "",
            };
        }
    }
}
