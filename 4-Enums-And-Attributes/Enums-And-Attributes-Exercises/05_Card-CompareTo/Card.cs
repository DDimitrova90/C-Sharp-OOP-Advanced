namespace _05_Card_CompareTo
{
    using System;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public Rank Rank { get; private set; }

        public Suit Suit { get; private set; }

        public int CompareTo(Card otherCard)
        {
            return this.GetPower().CompareTo(otherCard.GetPower());
        }

        public int GetPower()
        {
            return (int)this.Rank + (int)this.Suit;
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
        }
    }
}
