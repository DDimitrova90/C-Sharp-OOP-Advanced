namespace _01_Database.Contracts
{
    public interface IDatabase
    {
        int Count { get; }

        void Add(int element);

        void Remove();

        int[] Fetch();
    }
}
