namespace _10_Create_Custom_Class_Attribute
{
    using System;

    public class Gem
    {
        public Gem(string clarity)
        {
            this.Clarity = (Clarity)Enum.Parse(typeof(Clarity), clarity);
        }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public Clarity Clarity { get; private set; }
    }
}
