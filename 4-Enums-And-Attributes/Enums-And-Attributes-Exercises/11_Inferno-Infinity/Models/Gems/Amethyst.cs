namespace _11_Inferno_Infinity.Models.Gems
{
    using Interfaces;
    using System;
    using Enums;

    public class Amethyst : IGem
    {
        private int clarityLevel;

        public Amethyst(string clarity)
        {
            this.Clarity = (Clarity)Enum.Parse(typeof(Clarity), clarity);
            this.clarityLevel = (int)this.Clarity;
            this.Strength = 2 + this.clarityLevel;
            this.Agility = 8 + this.clarityLevel;
            this.Vitality = 4 + this.clarityLevel;
        }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public Clarity Clarity {  get; private set; }
    }
}
