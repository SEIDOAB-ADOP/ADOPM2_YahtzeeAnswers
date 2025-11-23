namespace M3_Yahtzee
{
    class CupDoubleDice : CupOfDice, ICupDoubleDice
    {
        public bool IsPair => this[0] == this[1];
        public CupDoubleDice() : base(2) { }
    }
}
