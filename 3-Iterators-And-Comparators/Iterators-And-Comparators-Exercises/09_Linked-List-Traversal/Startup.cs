namespace _09_Linked_List_Traversal
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Add":
                        int elementToAdd = int.Parse(tokens[1]);
                        linkedList.Add(elementToAdd);
                        break;

                    case "Remove":
                        int elementToRemove = int.Parse(tokens[1]);
                        linkedList.Remove(elementToRemove);
                        break;
                }
            }

            Console.WriteLine(linkedList.Count);

            StringBuilder sb = new StringBuilder();

            foreach (var element in linkedList)
            {
                sb.Append($"{element} ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
