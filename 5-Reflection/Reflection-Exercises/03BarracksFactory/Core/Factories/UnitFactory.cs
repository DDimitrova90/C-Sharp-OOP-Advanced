namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using Models.Units;

    public class UnitFactory : IUnitFactory
    {
        private string unitNameSpace = typeof(Unit).Namespace + ".";

        public IUnit CreateUnit(string unitType)
        {
            Type currUnitType = Type.GetType(unitNameSpace + unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(currUnitType, new object[] { });

            return unitInstance;
        }
    }
}
