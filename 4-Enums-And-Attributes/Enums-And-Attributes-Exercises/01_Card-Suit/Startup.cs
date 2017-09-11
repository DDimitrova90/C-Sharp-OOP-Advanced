namespace _01_Card_Suit
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Array values = Enum.GetValues(typeof(CardSuits));

            Console.WriteLine($"{input}:");

            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
