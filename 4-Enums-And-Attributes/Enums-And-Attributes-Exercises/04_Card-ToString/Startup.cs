namespace _04_Card_ToString
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string cardRank = Console.ReadLine();
            string cardSuit = Console.ReadLine();

            Card card = new Card(cardRank, cardSuit);

            Console.WriteLine(card);
        }
    }
}
