namespace _08_Card_Game
{
    using System;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(string rank, string suit)
        {
            this.rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public Rank Rank
        {
            get { return this.rank; }

            private set { this.rank = value; }
        }

        public Suit Suit
        {
            get { return this.suit; }

            private set { this.suit = value; }
        }

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
