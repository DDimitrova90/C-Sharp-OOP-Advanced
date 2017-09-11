namespace _08_Custom_List
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
