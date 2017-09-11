namespace _11_Inferno_Infinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        Clarity Clarity { get; }
    }
}
