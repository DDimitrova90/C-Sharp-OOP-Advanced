namespace _07_Food_Shortage.Interfaces
{
    public interface IPerson : IBuyer
    {
        string Name { get; }

        int Age { get; }
    }
}
