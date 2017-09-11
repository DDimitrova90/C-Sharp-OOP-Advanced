namespace _03BarracksFactory.Core.Commands
{
    using Contracts;

    public class RetireCommand : Command, IExecutable
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.Repository.RemoveUnit(unitType);
            string output = unitType + " retired!";
            return output;
        }
    }
}
