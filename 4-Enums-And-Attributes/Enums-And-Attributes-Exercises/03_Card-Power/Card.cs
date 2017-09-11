namespace _03_Card_Power
{
    using System;

    public class Card
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public Rank Rank { get; private set; }

        public Suit Suit { get; private set; }

        public int GetPower()
        {
            return (int)this.Rank + (int)this.Suit;
        }
    }
}
