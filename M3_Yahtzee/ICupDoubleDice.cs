using System;
namespace M3_Yahtzee
{
    /// <summary>
    /// A cup with only 2 dice
    /// </summary>
	public interface ICupDoubleDice : ICupOfDice
	{
        /// <summary>
        /// IsPair = both dice have same face, e.g. 1 - 1, 2 - 2
        /// </summary>
        public bool IsPair { get; }
    }
}

