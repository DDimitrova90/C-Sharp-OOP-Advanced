namespace _03BarracksFactory.Core
{
    using Commands;
    using Contracts;
    using System;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public string InterpretCommand(string input)
        {
            string[] data = input.Split(' ');
            string commandName = data[0];
            IExecutable command = ParseCommand(data, commandName);
            string result = command.Execute();
            return result;
        }

        private IExecutable ParseCommand(string[] data, string commandName)
        {
            string firstLetter = commandName.First().ToString().ToUpper();
            string otherPart = commandName.Substring(1).ToLower() + "Command";
            commandName = firstLetter + otherPart;
            string nameSpace = typeof(Command).Namespace + ".";
            Type commandType = Type.GetType(nameSpace + commandName);
            IExecutable commandInstance = (IExecutable)Activator.CreateInstance(commandType, new object[] { data, this.repository, this.unitFactory });
            return commandInstance;
        }
    }
}
