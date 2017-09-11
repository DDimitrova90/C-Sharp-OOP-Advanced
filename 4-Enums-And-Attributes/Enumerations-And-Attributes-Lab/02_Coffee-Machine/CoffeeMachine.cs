namespace _02_Coffee_Machine
{
    using System;
    using System.Collections.Generic;

    public class CoffeeMachine
    {
        private int coins;

        public CoffeeMachine()
        {
            this.CoffeesSold = new List<CoffeeType>();
        }

        public List<CoffeeType> CoffeesSold { get; }

        public void BuyCoffee(string size, string type)
        {
            CoffeePrice price;
            bool isPriceCorrect = Enum.TryParse(size, out price);
            CoffeeType coffeeType;
            bool isTypeCorrect = Enum.TryParse(type, out coffeeType);

            if (this.coins >= (int)price)
            {
                this.coins = 0;
                this.CoffeesSold.Add(coffeeType);
            }
        }

        public void InsertCoin(string coin)
        {
            Coin coinAmount;
            bool isCoin = Enum.TryParse(coin, out coinAmount);
            this.coins += (int)coinAmount;
        }
    }
}
