namespace BashSoft
{
    using System;
    using Contracts;

    public class InputReader : IReader
    {
        private const string ЕndCommand = "quit";
        private IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != ЕndCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}
