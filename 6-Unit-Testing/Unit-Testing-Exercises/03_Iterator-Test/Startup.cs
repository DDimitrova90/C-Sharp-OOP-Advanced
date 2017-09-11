namespace _03_Iterator_Test
{
    using Contracts;
    using Models;
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] commandArgs = Console.ReadLine().Split(' ');
            IListIterator myList = null;
            IOutputWriter outputWriter = new OutputWriter();

            try
            {
                myList = new ListIterator(commandArgs.Skip(1).ToArray());
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "HasNext":
                            outputWriter.WriteLine(myList.HasNext().ToString());
                            break;
                        case "Move":
                            outputWriter.WriteLine(myList.Move().ToString());
                            break;
                        case "Print":
                            myList.Print();
                            break;
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                
                command = Console.ReadLine();
            }
        }
    }
}
