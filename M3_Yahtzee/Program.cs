using System;
using Seido.Utilities.ConsoleInput;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!ConsoleInput.TryReadInt32("How many dices should the cup contain", 1, 10, out int NrOfDices))
                    return;

                #region sprint 3
                Console.WriteLine("\n\nSprint 3");

                ICupOfDice cup = new CupOfDice(NrOfDices);
                Console.WriteLine($"Newly created cup\n{cup}");
                Console.WriteLine($"Same cup sorted\n{cup.Sort()}");
                Console.WriteLine($"Shaken cup\n{cup.Shake()}");
                Console.WriteLine($"Shaken cup sorted\n{cup.Sort()}");

                Console.WriteLine($"Dice[0] in cup: {cup[0]}");
                Console.WriteLine($"Dice[{cup.Count - 1}] in cup: {cup[cup.Count - 1]}");
                Console.WriteLine($"Highest dice in cup: {cup.Highest}");
                Console.WriteLine($"Lowest dice in cup: {cup.Lowest}");
                #endregion

                #region sprint 4
                Console.WriteLine("\n\nSprint 4");

                ICupDoubleDice doubleDice = new CupDoubleDice();
                Console.WriteLine($"Cup of double dices\n{doubleDice}");
                Console.WriteLine($"IsPair: {doubleDice.IsPair}");
                #endregion


                #region sprint 5
                Console.WriteLine("\n\nSprint 5");

                //Test the YahtzeeDices
                ICupYahtzeeDice yahtzeeDice = new CupYahtzeeDice();
                Console.WriteLine($"Cup of Yahtzee dices\n{yahtzeeDice}");
                Console.WriteLine($"IsYahtzee: {yahtzeeDice.IsYahtzee}");
                Console.WriteLine($"IsLargeStraight: {yahtzeeDice.IsLargeStraight}");
                Console.WriteLine($"Chance: {yahtzeeDice.Chance}");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error throwing the dice. Error: {ex.Message}");
            }

            Console.WriteLine("\n\nThank you for playing");
        }
    }
}
