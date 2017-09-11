namespace _08_Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            List<Card> firstPlayerHand = new List<Card>();
            List<Card> secondPlayerHand = new List<Card>();

            while (true)
            {
                if (firstPlayerHand.Count == 5 && secondPlayerHand.Count == 5)
                {
                    break;
                }

                string[] cardArgs = Console.ReadLine().Split(' ');
                string rank = cardArgs[0];
                string suit = cardArgs[2];

                try
                {
                    Card card = new Card(rank, suit);

                    if (firstPlayerHand.FirstOrDefault(c => c.Rank == card.Rank && c.Suit == card.Suit) != null || secondPlayerHand.FirstOrDefault(c => c.Rank == card.Rank && c.Suit == card.Suit) != null)
                    {
                        Console.WriteLine("Card is not in the deck.");
                        continue;
                    }

                    if (firstPlayerHand.Count < 5)
                    {
                        firstPlayerHand.Add(card);
                    }
                    else if (firstPlayerHand.Count == 5)
                    {
                        secondPlayerHand.Add(card);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            Card firstPlayerBestCard = firstPlayerHand[0];

            foreach (var card in firstPlayerHand)
            {
                if (firstPlayerBestCard.GetPower() < card.GetPower())
                {
                    firstPlayerBestCard = card;
                }
            }

            Card secondPlayerBestCard = secondPlayerHand[0];

            foreach (var card in secondPlayerHand)
            {
                if (secondPlayerBestCard.GetPower() < card.GetPower())
                {
                    secondPlayerBestCard = card;
                }
            }

            if (firstPlayerBestCard.CompareTo(secondPlayerBestCard) > 0)
            {
                Console.WriteLine($"{firstPlayerName} wins with {firstPlayerBestCard.Rank} of {firstPlayerBestCard.Suit}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayerName} wins with {secondPlayerBestCard.Rank} of {secondPlayerBestCard.Suit}.");
            }
        }
    }
}
