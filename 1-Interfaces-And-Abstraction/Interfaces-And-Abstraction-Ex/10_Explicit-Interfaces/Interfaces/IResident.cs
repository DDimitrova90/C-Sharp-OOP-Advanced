namespace _10_Explicit_Interfaces.Interfaces
{
    public interface IResident : INameable
    {
        string Country { get; }

        string GetName();
    }
}
