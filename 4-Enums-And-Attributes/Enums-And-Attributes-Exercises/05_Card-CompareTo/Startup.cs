namespace _05_Card_CompareTo
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string firstCardRank = Console.ReadLine();
            string firstCardSuit = Console.ReadLine();
            Card firstCard = new Card(firstCardRank, firstCardSuit);

            string secondCardRank = Console.ReadLine();
            string secondCardSuit = Console.ReadLine();
            Card secondCard = new Card(secondCardRank, secondCardSuit);

            if (firstCard.CompareTo(secondCard) < 0)
            {
                Console.WriteLine(secondCard);
            }
            else
            {
                Console.WriteLine(firstCard);
            }
        }
    }
}
