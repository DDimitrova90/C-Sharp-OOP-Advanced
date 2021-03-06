﻿namespace BashSoft.IO.Commands
{
    using Contracts;
    using Exceptions;
    using Attributes;

    [Alias("readdb")]
    public class ReadDatabaseCommand : Command, IExecutable
    {
        [Inject]
        private IDatabase repository;

        public ReadDatabaseCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string fileName = this.Data[1];
                this.repository.LoadData(fileName);
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
