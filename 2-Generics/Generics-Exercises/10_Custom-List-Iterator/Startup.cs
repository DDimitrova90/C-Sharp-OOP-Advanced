namespace _10_Custom_List_Iterator
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            CommandInterpreter interpreter = new CommandInterpreter();

            while (interpreter.IsRunning)
            {
                string input = Console.ReadLine();
                interpreter.InterpredCommand(input);
            }
        }
    }
}
