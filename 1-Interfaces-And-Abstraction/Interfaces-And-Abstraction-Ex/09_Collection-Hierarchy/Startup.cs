namespace _09_Collection_Hierarchy
{
    using Interfaces;
    using Models;
    using System;

    public class Startup
    {
        public static void Main()
        {
            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();

            string[] items = Console.ReadLine().Split();
            
            string addCollectionResult = string.Empty;
            string addRemoveCollectionResult = string.Empty;
            string myListResult = string.Empty;

            foreach (var item in items)
            {
                addCollectionResult += addCollection.Add(item) + " ";
                addRemoveCollectionResult += addRemoveCollection.Add(item) + " ";
                myListResult += myList.Add(item) + " ";
            }

            Console.WriteLine(addCollectionResult.TrimEnd());
            Console.WriteLine(addRemoveCollectionResult.TrimEnd());
            Console.WriteLine(myListResult.TrimEnd());

            int removeCommandsCount = int.Parse(Console.ReadLine());

            addRemoveCollectionResult = string.Empty;
            myListResult = string.Empty;

            for (int i = 0; i < removeCommandsCount; i++)
            {
                addRemoveCollectionResult += addRemoveCollection.Remove() + " ";
                myListResult += myList.Remove() + " ";
            }

            Console.WriteLine(addRemoveCollectionResult.TrimEnd());
            Console.WriteLine(myListResult.TrimEnd());
        }
    }
}
