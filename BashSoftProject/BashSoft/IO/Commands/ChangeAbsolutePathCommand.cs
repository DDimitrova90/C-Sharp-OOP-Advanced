﻿namespace BashSoft.IO.Commands
{
    using Contracts;
    using Exceptions;
    using Attributes;

    [Alias("cdabs")]
    public class ChangeAbsolutePathCommand : Command, IExecutable
    {
        [Inject]
        private IDirectoryManager inputOutputManager;

        public ChangeAbsolutePathCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string absolutePath = this.Data[1];
                this.inputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
