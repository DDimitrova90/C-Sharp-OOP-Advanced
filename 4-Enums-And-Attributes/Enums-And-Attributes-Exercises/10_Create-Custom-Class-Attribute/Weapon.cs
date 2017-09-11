namespace _10_Create_Custom_Class_Attribute
{
    using System;

    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class Weapon
    {
        public Weapon(string rarity, string name)
        {
            this.Rarity = (Rarity)Enum.Parse(typeof(Rarity), rarity);
            this.Name = name;
            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
        }

        public string Name { get; private set; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public int SocketsCount { get; private set; }

        public Rarity Rarity { get; private set; }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public void AddGem(int index, Gem gem)
        {
        }

        public void RemoveGem(int index)
        {
        }

        public void CalculateStats()
        {
        }
    }
}
