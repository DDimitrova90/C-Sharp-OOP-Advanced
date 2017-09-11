namespace _02_Extended_Database.Contracts
{
    public interface IDatabase
    {
        int Count { get; }

        void Add(IPerson person);

        void Remove();

        IPerson FindById(long id);

        IPerson FindByUsername(string username);
    }
}
