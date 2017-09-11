namespace _11_Inferno_Infinity.Models.Weapons
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public class Axe : IWeapon
    {
        private readonly IList<IGem> sockets;
        private int rarityLevel;

        public Axe(string rarity, string name)
        {
            this.SocketsCount = 4;
            this.sockets = new List<IGem>(new IGem[this.SocketsCount]);
            this.Name = name;
            this.Rarity = (Rarity)Enum.Parse(typeof(Rarity), rarity);
            this.rarityLevel = (int)this.Rarity;
            this.MaxDamage = 10 * this.rarityLevel;
            this.MinDamage = 5 * this.rarityLevel;
            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
        }

        public string Name { get; private set; }

        public int MaxDamage { get; private set; }

        public int MinDamage { get; private set; }

        public Rarity Rarity { get; private set; }

        public int SocketsCount { get; private set; }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public void AddGem(int index, IGem gem)
        {
            if (index >= 0 && index < this.SocketsCount)
            {
                this.sockets[index] = gem;
            }
        }

        public void RemoveGem(int index)
        {
            if (index >= 0 && index < this.SocketsCount && this.sockets[index] != null)
            {
                this.sockets[index] = null;
            }
        }

        public void CalculateStats()
        {
            foreach (var gem in this.sockets)
            {
                if (gem != null)
                {
                    this.Strength += gem.Strength;
                    this.Agility += gem.Agility;
                    this.Vitality += gem.Vitality;
                    this.MinDamage += (2 * gem.Strength) + (1 * gem.Agility);
                    this.MaxDamage += (3 * gem.Strength) + (4 * gem.Agility);
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}
