// Copyright © - unpublished - Toby Hunter
namespace Kingdom_Come_Deliverance_Dice.Models
{
    internal class RoundModel
    {
        public int SelectedScore { get; set; }
        public int PreviousSelectedScore { get; set; }
        public Dictionary<int, int> CombosAchieved { get; set; } = new();
        public int ScoreBeforeStraight { get; set; }
        public bool StraightAchieved { get; set; } = false;
    }
}
