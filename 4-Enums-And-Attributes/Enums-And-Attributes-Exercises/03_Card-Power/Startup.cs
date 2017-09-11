namespace _03_Card_Power
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string cardRank = Console.ReadLine();
            string cardSuit = Console.ReadLine();

            Card card = new Card(cardRank, cardSuit);

            Console.WriteLine($"Card name: {card.Rank} of {card.Suit}; Card power: {card.GetPower()}");
        }
    }
}
