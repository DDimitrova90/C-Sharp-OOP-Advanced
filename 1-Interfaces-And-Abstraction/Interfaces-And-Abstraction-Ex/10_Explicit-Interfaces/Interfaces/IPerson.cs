namespace _10_Explicit_Interfaces.Interfaces
{
    public interface IPerson : INameable
    {
        int Age { get; }

        string GetName();
    }
}
