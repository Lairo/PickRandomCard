using System;

namespace PickRandomCards
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine($"You picked a: {card}");
                }
                // this block is executed if line COULD be converted to an int
                // value that's stored in a new variable called numberOfCards
            }
            else
            {
                Console.WriteLine("Positive whole numbers only please");
                Main();
                // this block is executed if line COULD NOT be converted to an int
            }

        }
    }
}