using System;
namespace M3_Yahtzee
{
    /// <summary>
    /// A cup with 5 dice
    /// </summary>
	public interface ICupYahtzeeDice : ICupOfDice
    {
        /// <summary>
        /// LargeStraight = all five dices are in sequential order 1..5 or 2..6
        /// </summary>
        public bool IsLargeStraight { get; }

        /// <summary>
        /// Yahtzee = all five dices have the same FaceValue
        /// </summary>
        public bool IsYahtzee { get; }

        /// <summary>
        /// Chance = sum of all five dices
        /// </summary>
        public int Chance { get; }
    }
}

