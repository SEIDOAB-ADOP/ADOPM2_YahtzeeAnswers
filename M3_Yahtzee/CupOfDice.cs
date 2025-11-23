using System;
using System.Collections.Generic;
using Seido.Utilities.SeedGenerator;


namespace M3_Yahtzee
{
    //Sprint 2
    /// <summary>
    /// Cup with 1 to 10 dice
    /// </summary>
    class CupOfDice : ICupOfDice
    {
        SeedGenerator _rnd = new SeedGenerator();
        protected List<DiceFace> _dices;

        public int Count => _dices.Count;
        public DiceFace this[int idx] => _dices[idx];

        public DiceFace Highest
        {
            get
            {
                Sort();
                return this[Count - 1];
            }
        }
        public DiceFace Lowest
        {
            get
            {
                Sort();
                return this[0];
            }
        }

        public ICupOfDice Sort()
        {
            _dices.Sort();
            return this;
        }
        public ICupOfDice Shake()
        {
            for (int i = 0; i < _dices.Count; i++)
            {
                _dices[i] = _rnd.FromEnum<DiceFace>();
            }
            return this;
        }

        public override string ToString()
        {
            string sRet = $"";
            for (int i = 0; i < Count; i++)
            {
                sRet += $"{this[i],8},";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public CupOfDice(int nrOfDices)
        {
            if (nrOfDices < 1 || nrOfDices > 10)
                throw new IndexOutOfRangeException("Wrong number of Dices");

            _dices = new List<DiceFace>();
            for (int i = 0; i < nrOfDices; i++)
            {
                _dices.Add(_rnd.FromEnum<DiceFace>());
            }
        }
    }
}
