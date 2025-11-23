using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Yahtzee
{
    public enum DiceFace { One=1, Two, Three, Four, Five, Six}
    public interface ICupOfDice
    {
        /// <summary>
        /// Nr of Dices in the cup
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// The value of a specific dice
        /// </summary>
        /// <param name="idx">Dice: 0 to Count-1</param>
        /// <returns>The value of dice with idx. Throws IndexOutOfRangeException for invalid idx and if Count is 0
        /// </returns>
        public DiceFace this[int idx] { get; }

        /// <summary>
        /// Get the DiceFace of the highest Dice in the cup. Throws IndexOutOfRangeException if Count is 0
        /// </summary>
        public DiceFace Highest { get; }

        /// <summary>
        /// Get the DiceFace of the lowest Dice in the cup. Throws IndexOutOfRangeException if Count is 0
        /// </summary>
        public DiceFace Lowest { get; }

        /// <summary>
        /// Sort the dices in the cup in ascending order
        /// </summary>
        public ICupOfDice Sort();

        /// <summary>
        /// Shake the cup and create new random DiceFaces.
        /// </summary>
        public ICupOfDice Shake();

        //ToString()
        //Should override ToString() to print out the dices in the cup

        //Constructors, Should contain one constructors
        //Constructor (int NrOfDices) : Nr of Dices in the cup, Min 1, Maximum 10
    }
}
