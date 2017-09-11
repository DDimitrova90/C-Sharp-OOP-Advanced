namespace _01_ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string> createCommand = Console.ReadLine().Split().ToList();
            List<string> elements = createCommand.Skip(1).ToList();
            ListyIterator<string> listIterator = new ListyIterator<string>(elements);

            string command = Console.ReadLine();
            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listIterator.Print());
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
