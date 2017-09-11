namespace _11_Inferno_Infinity.Core
{
    using System;

    public class Engine
    {
        private CommandIntepreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandIntepreter();
        }

        public void Run()
        {
            while (this.interpreter.IsRunning)
            {
                string input = Console.ReadLine();
                this.interpreter.ReadCommand(input);
            }
        }
    }
}
