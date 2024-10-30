using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Come_Deliverance_Dice
{
    internal class Rules
    {
        // Determines the status of the game.
        public static void IsBust()
        {
            //if (Game_Data.Player == 1)
            //{
            //    if (Game_Data.P1HeldDice == Array.Empty<int>())
            //    {
            //        if (Dice_Model.P1D1 != 1 && Dice_Model.P1D1 != 5 && Dice_Model.P1D2 != 1 && Dice_Model.P1D2 != 5 && Dice_Model.P1D3 != 1 && Dice_Model.P1D3 != 5
            //         && Dice_Model.P1D4 != 1 && Dice_Model.P1D4 != 5 && Dice_Model.P1D5 != 1 && Dice_Model.P1D5 != 5 && Dice_Model.P1D6 != 1 && Dice_Model.P1D6 != 5)
            //        {
            //            if (!CanCombo())
            //            {
            //                Game_Text.Text = Game_Text.Text.Remove(207, 13).Insert(207, "*You've Bust*");
            //
            //                Console.Clear();
            //                Console.WriteLine(Game_Text.Text);
            //                Console.WriteLine();
            //                Console.WriteLine(string.Format(Game_Text.Score, Game_Data.TargetScore, Game_Data.TargetScore));
            //            }
            //        }
            //    }
            //
            //    else
            //    {
            //        int ScoringDice = 0;
            //
            //        for (int x = 0; x < 6; x++)
            //        {
            //            if (!Game_Data.P1HeldDice.Contains(x+ 1))
            //            {
            //                int Roll = GetDiceValue(x + 1);
            //
            //                if (Roll == 1 || Roll == 5)
            //                {
            //                    ScoringDice++;
            //                }
            //            }
            //        }
            //
            //        if (ScoringDice == 0)
            //        {
            //            if (!CanCombo())
            //            {
            //                Game_Text.Text = Game_Text.Text.Remove(207, 13).Insert(207, "*You've Bust*");
            //            }
            //        }
            //    }
            //}
        }

        // Gets the value of the dice.
        private static int GetDiceValue(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    return Dice switch
            //    {
            //        1 => Dice_Model.P1D1,
            //        2 => Dice_Model.P1D2,
            //        3 => Dice_Model.P1D3,
            //        4 => Dice_Model.P1D4,
            //        5 => Dice_Model.P1D5,
            //        6 => Dice_Model.P1D6,
            //        _ => 0
            //    };
            //}

            return 0;
        }

        // Checks if a Combo is possible.
        private static bool CanCombo()
        {
            //if (Game_Data.Player == 1)
            //{
            //    int[] Rolls = { Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6 };
            //    Dictionary<int, int> Counts = new();
            //
            //    for (int x = 0; x < Rolls.Length; x++)
            //    {
            //        if (!Game_Data.P1HeldDice.Contains(x + 1))
            //        {
            //            if (Counts.ContainsKey(Rolls[x]))
            //            {
            //                Counts[Rolls[x]]++;
            //            }
            //
            //            else
            //            {
            //                Counts[Rolls[x]] = 1;
            //            }
            //        }
            //    }
            //
            //    foreach (var Count in Counts)
            //    {
            //        if (Count.Value > 2)
            //        {
            //            return true;
            //        }
            //    }
            //
            //    return false;
            //}

            return false;
        }

        // Checks the scores against the combinations.
        private static void ScoreCombination()
        {
            if (!IsStraight())
            {
                //if (Game_Data.Player == 1)
                //{
                //    bool[] Selected = { Game_Data.P1D1Selected, Game_Data.P1D2Selected, Game_Data.P1D3Selected, Game_Data.P1D4Selected, Game_Data.P1D5Selected, Game_Data.P1D6Selected };
                //    int[] Rolls = { Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6 };
                //    Dictionary<int, int> Counts = new();
                //
                //    for (int x = 0; x < Selected.Length; x++)
                //    {
                //        if (Selected[x])
                //        {
                //            if (Counts.ContainsKey(Rolls[x]))
                //            {
                //                Counts[Rolls[x]]++;
                //            }
                //
                //            else
                //            {
                //                Counts[Rolls[x]] = 1;
                //            }
                //        }
                //    }
                //
                //    foreach (var Count in Counts)
                //    {
                //        if (Count.Value > 2)
                //        {
                //            bool ComboUpdated = false;
                //            bool ComboCreated = false;
                //
                //            foreach (var Combo in Game_Data.CombosAchieved)
                //            {
                //                if (Combo.Key == Count.Key && Combo.Value != Count.Value)
                //                {
                //                    Game_Data.Selected -= GetComboPoints(Combo.Key, Combo.Value);
                //                    Game_Data.Selected += GetComboPoints(Count.Key, Count.Value);
                //                    Game_Data.CombosAchieved.Remove(Combo.Key);
                //                    Game_Data.CombosAchieved.Add(Count.Key, Count.Value);
                //                    ComboUpdated = true;
                //                }
                //
                //                else if (Combo.Key == Count.Key && Combo.Value == Count.Value)
                //                {
                //                    ComboCreated = true;
                //                }
                //            }
                //
                //            if (!ComboUpdated && !ComboCreated)
                //            {
                //                if (Count.Key == 1 || Count.Key == 5)
                //                {
                //                    Game_Data.Selected -= GetPoints(Count.Key) * Count.Value;
                //                }
                //
                //                Game_Data.Selected += GetComboPoints(Count.Key, Count.Value);
                //                Game_Data.CombosAchieved.Add(Count.Key, Count.Value);
                //            }
                //        }
                //
                //        else
                //        {
                //            foreach (var Combo in Game_Data.CombosAchieved)
                //            {
                //                if (Combo.Key == Count.Key)
                //                {
                //                    Game_Data.Selected -= GetComboPoints(Combo.Key, Combo.Value);
                //                    Game_Data.CombosAchieved.Remove(Combo.Key);
                //
                //                    if (Count.Key == 1 || Count.Key == 5)
                //                    {
                //                        Game_Data.Selected += GetPoints(Count.Key) * (Count.Value + 1);
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
            }
        }

        // Checks if a straight is achieved.
        private static bool IsStraight()
        {
            //if (Game_Data.Player == 1)
            //{
            //    bool[] Selected = { Game_Data.P1D1Selected, Game_Data.P1D2Selected, Game_Data.P1D3Selected, Game_Data.P1D4Selected, Game_Data.P1D5Selected, Game_Data.P1D6Selected };
            //    int[] Rolls = { Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6 };
            //    int[] StraightCheck = Array.Empty<int>();
            //
            //    for (int x = 0; x < Selected.Length; x++)
            //    {
            //        if (Selected[x])
            //        {
            //            StraightCheck = StraightCheck.Append(Rolls[x]).ToArray();
            //        }
            //    }
            //
            //    if (StraightCheck.Length == 6)
            //    {
            //        Array.Sort(StraightCheck);
            //
            //        for (int i = 0; i < StraightCheck.Length; i++)
            //        {
            //            if (StraightCheck[i] != i + 1)
            //            {
            //                return false;
            //            }
            //        }
            //
            //        Game_Data.BeforeStraight = Game_Data.Selected;
            //        Game_Data.Selected = 1500;
            //        Game_Data.StraightAchieved = true;
            //        return true;
            //    }
            //
            //    if (Game_Data.Selected == 1500)
            //    {
            //        Game_Data.Selected = Game_Data.BeforeStraight;
            //        return false;
            //    }
            //}

            return false;
        }

        // Gets the combination points.
        private static int GetComboPoints(int Dice, int Combo)
        {
            if (Dice == 1 && Combo == 3)
            {
                return 1000;
            }

            return Combo switch
            {
                3 => 100 * Dice,
                4 => (100 * Dice) * 2,
                5 => ((100 * Dice) * 2) * 2,
                _ => 0
            };
        }

        // Handles the addition of points.
        public static void SelectedPoints(int Dice)
        {
            //if (Game_Data.Player == 1)
            //{
            //    switch (Dice)
            //    {
            //        case 1: CalculatePoints(Game_Data.P1D1Selected, Dice_Model.P1D1); break;
            //        case 2: CalculatePoints(Game_Data.P1D2Selected, Dice_Model.P1D2); break;
            //        case 3: CalculatePoints(Game_Data.P1D3Selected, Dice_Model.P1D3); break;
            //        case 4: CalculatePoints(Game_Data.P1D4Selected, Dice_Model.P1D4); break;
            //        case 5: CalculatePoints(Game_Data.P1D5Selected, Dice_Model.P1D5); break;
            //        case 6: CalculatePoints(Game_Data.P1D6Selected, Dice_Model.P1D6); break;
            //    }
            //}
        }

        // Calculates whether it's addition or subtraction.
        private static void CalculatePoints(bool Selected, int Roll)
        {
            switch (Selected)
            {
                //case true: Game_Data.PreviousSelected = Game_Data.Selected; Game_Data.Selected += GetPoints(Roll); ScoreCombination(); Game.UpdateScoreTable("Selected"); break;
                //case false: Game_Data.PreviousSelected = Game_Data.Selected; Game_Data.Selected -= GetPoints(Roll); ScoreCombination(); Game.UpdateScoreTable("Selected"); break;
            }
        }

        // Gets the points.
        private static int GetPoints(int Roll)
        {
            return Roll switch
            {
                1 => 100,
                5 => 50,
                _ => 0
            };
        }

        // Checks if the dice is used in a combo.
        public static bool UsedInComboOrStraight(int Dice)
        {
            //foreach (var Combo in Game_Data.CombosAchieved)
            //{
            //    if (Combo.Key == Dice)
            //    {
            //        return true;
            //    }
            //}
            //
            //if (Game_Data.StraightAchieved)
            //{
            //    return true;
            //}

            return false;
        }

        // Checks if the board has been cleared.
        public static void IsBoardCleared()
        {
            //if (Game_Data.Player == 1)
            //{
            //    if (Game_Data.StraightAchieved || Game_Data.P1HeldDice.Length == 6)
            //    {
            //        Dice_Roll.RollDice(1);
            //        Game_Text.Text = string.Format(Game_Text.P1Roll, Dice_Model.P1D1, Dice_Model.P1D2, Dice_Model.P1D3, Dice_Model.P1D4, Dice_Model.P1D5, Dice_Model.P1D6);
            //    }
            //}
        }
    }
}
