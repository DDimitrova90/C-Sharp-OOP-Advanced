namespace _11_Inferno_Infinity.Models.Gems
{
    using Interfaces;
    using System;
    using Enums;

    public class Ruby : IGem
    {
        private int clarityLevel;

        public Ruby(string clarity)
        {
            this.Clarity = (Clarity)Enum.Parse(typeof(Clarity), clarity);
            this.clarityLevel = (int)this.Clarity;
            this.Strength = 7 + this.clarityLevel;
            this.Agility = 2 + this.clarityLevel;
            this.Vitality = 5 + this.clarityLevel;
        }       

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public Clarity Clarity { get; private set; }
    }
}
