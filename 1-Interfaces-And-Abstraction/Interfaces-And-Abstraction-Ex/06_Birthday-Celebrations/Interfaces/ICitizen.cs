namespace _06_Birthday_Celebrations.Interfaces
{
    public interface ICitizen : IHabitant, IBirthdateable
    {
        int Age { get; }
    }
}
