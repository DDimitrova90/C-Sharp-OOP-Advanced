namespace _11_Inferno_Infinity.Models.Gems
{
    using Interfaces;
    using System;
    using Enums;

    public class Emerald : IGem
    {
        private int clarityLevel;

        public Emerald(string clarity)
        {
            this.Clarity = (Clarity)Enum.Parse(typeof(Clarity), clarity);
            this.clarityLevel = (int)this.Clarity;
            this.Strength = 1 + this.clarityLevel;
            this.Agility = 4 + this.clarityLevel;
            this.Vitality = 9 + this.clarityLevel;
        }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public Clarity Clarity { get; private set; }    
    }
}
