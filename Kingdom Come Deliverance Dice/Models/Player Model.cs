// Copyright © - unpublished - Toby Hunter
namespace Kingdom_Come_Deliverance_Dice.Models
{
    internal class PlayerModel
    {
        public int Number { get; set; }
        public int Pot { get; set; }
        public List<DiceModel> Dice { get; set; } = new();
    }
}
