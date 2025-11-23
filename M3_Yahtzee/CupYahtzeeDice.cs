namespace M3_Yahtzee
{
    class CupYahtzeeDice : CupOfDice, ICupYahtzeeDice
    {
        public bool IsLargeStraight
        {
            get
            {
                var prevDice = this[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this[i] == prevDice + 1)
                        prevDice = this[i];
                    else
                        return false;
                }
                return true;
            }
        }

        public bool IsYahtzee
        {
            get
            {
                var firstDice = this[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this[i] != firstDice)
                        return false;
                }
                return true;
            }
        }

        public int Chance
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Count; i++)
                {
                    sum += (int) this[i];
                }

                return sum;
            }
        }

        public CupYahtzeeDice() : base(5) { }
    }
}
