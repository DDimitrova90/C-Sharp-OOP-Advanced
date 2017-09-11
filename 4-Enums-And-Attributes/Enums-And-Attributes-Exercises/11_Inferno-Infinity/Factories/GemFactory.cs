namespace _11_Inferno_Infinity.Factories
{
    using Interfaces;
    using Models.Gems;
    using System;

    public class GemFactory
    {
        public IGem GetGem(string input)
        {
            string[] inputArgs = input.Split(' ');
            string clarity = inputArgs[0];
            string gemType = inputArgs[1];

            switch (gemType)
            {
                case "Ruby":
                    return new Ruby(clarity);
                case "Emerald":
                    return new Emerald(clarity);
                case "Amethyst":
                    return new Amethyst(clarity);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
