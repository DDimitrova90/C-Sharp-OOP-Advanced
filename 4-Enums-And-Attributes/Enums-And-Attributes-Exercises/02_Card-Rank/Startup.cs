namespace _02_Card_Rank
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine($"{input}:");
            Array values = Enum.GetValues(typeof(CardRank));

            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
