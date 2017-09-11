namespace _11_Inferno_Infinity
{
    using Enums;
    using Interfaces;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        int SocketsCount { get; }

        Rarity Rarity { get; }

        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        void AddGem(int index, IGem gem);

        void RemoveGem(int index);

        void CalculateStats();
    }
}
