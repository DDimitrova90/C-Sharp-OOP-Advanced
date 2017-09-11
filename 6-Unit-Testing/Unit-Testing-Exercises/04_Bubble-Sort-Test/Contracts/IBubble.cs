namespace _04_Bubble_Sort_Test.Contracts
{
    using System.Collections.Generic;

    public interface IBubble
    {
        IList<int> Sort(IList<int> collection);
    }
}
