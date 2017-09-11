namespace _03_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> myStack = new Stack<int>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split(new char[] { ' ', ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];

                if (command == "Push")
                {
                    List<int> elements = inputArgs.Skip(1).Select(int.Parse).ToList();
                    myStack.Push(elements);
                }
                else if (command == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                        return;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(myStack.Print());
            Console.WriteLine(myStack.Print());
        }
    }
}
