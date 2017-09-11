namespace _09_Custom_List_Sorter
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
