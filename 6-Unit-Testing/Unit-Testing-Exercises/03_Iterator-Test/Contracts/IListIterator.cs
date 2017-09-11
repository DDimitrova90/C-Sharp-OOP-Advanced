namespace _03_Iterator_Test.Contracts
{
    public interface IListIterator
    {
        int Count { get; }

        bool Move();

        bool HasNext();

        void Print();
    }
}
