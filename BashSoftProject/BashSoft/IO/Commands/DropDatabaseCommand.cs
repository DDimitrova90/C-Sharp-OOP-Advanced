﻿namespace BashSoft.IO.Commands
{
    using Contracts;
    using Exceptions;
    using Attributes;

    [Alias("dropdb")]
    public class DropDatabaseCommand : Command, IExecutable
    {
        [Inject]
        private IDatabase repository;

        public DropDatabaseCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
