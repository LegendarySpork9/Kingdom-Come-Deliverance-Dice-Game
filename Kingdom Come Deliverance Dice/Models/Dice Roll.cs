namespace Kingdom_Come_Deliverance_Dice
{
    internal class Dice_Roll
    {
        // Generates the random numbers.
        public static void RollDice(int Player)
        {
            switch (Player)
            {
                case 1: Player1Dice(); break;
                case 2: Player2Dice(); break;
            }
        }

        private static void Player1Dice()
        {
            Random Number = new();

            Dice_Model.P1D1 = Number.Next(1, 7);
            Dice_Model.P1D2 = Number.Next(1, 7);
            Dice_Model.P1D3 = Number.Next(1, 7);
            Dice_Model.P1D4 = Number.Next(1, 7);
            Dice_Model.P1D5 = Number.Next(1, 7);
            Dice_Model.P1D6 = Number.Next(1, 7);
        }

        private static void Player2Dice()
        {
            Random Number = new();

            Dice_Model.P2D1 = Number.Next(1, 7);
            Dice_Model.P2D2 = Number.Next(1, 7);
            Dice_Model.P2D3 = Number.Next(1, 7);
            Dice_Model.P2D4 = Number.Next(1, 7);
            Dice_Model.P2D5 = Number.Next(1, 7);
            Dice_Model.P2D6 = Number.Next(1, 7);
        }

        public static void ReRollDice(int Dice)
        {
            Random Number = new();

            if (Game_Data.Player == 1)
            {
                switch (Dice)
                {
                    case 1: Dice_Model.P1D1 = Number.Next(1, 7); break;
                    case 2: Dice_Model.P1D2 = Number.Next(1, 7); break;
                    case 3: Dice_Model.P1D3 = Number.Next(1, 7); break;
                    case 4: Dice_Model.P1D4 = Number.Next(1, 7); break;
                    case 5: Dice_Model.P1D5 = Number.Next(1, 7); break;
                    case 6: Dice_Model.P1D6 = Number.Next(1, 7); break;
                }
            }
        }
    }
}
