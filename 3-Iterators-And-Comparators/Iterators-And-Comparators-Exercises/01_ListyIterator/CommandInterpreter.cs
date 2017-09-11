namespace _01_ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter
    {
        private ListyIterator<string> listyIterator;

        public CommandInterpreter()
        {
            this.listyIterator = new ListyIterator<string>();
            this.IsRunning = true;
        }

        public bool IsRunning { get; private set; }

        public void InterpretCommand(string input)
        {
            string[] inputArgs = input.Split(' ');
            string command = inputArgs[0];
            List<string> elements = inputArgs.Skip(1).ToList();

            switch (command)
            {
                case "Create":
                    this.listyIterator = new ListyIterator<string>(elements.ToArray());
                    break;
                case "Move":
                    Console.WriteLine(this.listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(this.listyIterator.HasNext());
                    break;
                case "Print":
                    try
                    {
                        Console.WriteLine(this.listyIterator.Print());
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                    break;
                case "END":
                    this.IsRunning = false;
                    break;
            }
        }
    }
}
