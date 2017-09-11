namespace _07_Deck_Of_Cards
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] suitsValues = Enum.GetNames(typeof(Suit));
            string[] ranksValues = Enum.GetNames(typeof(Rank));

            foreach (var suitValue in suitsValues)
            {
                foreach (var rankValue in ranksValues)
                {
                    Console.WriteLine($"{rankValue} of {suitValue}");
                }
            }
        }
    }
}
