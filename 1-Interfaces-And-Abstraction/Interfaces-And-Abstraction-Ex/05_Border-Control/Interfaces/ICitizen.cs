namespace _05_Border_Control.Interfaces
{
    public interface ICitizen : IHabitant
    {
        string Name { get; }

        int Age { get; }
    }
}
