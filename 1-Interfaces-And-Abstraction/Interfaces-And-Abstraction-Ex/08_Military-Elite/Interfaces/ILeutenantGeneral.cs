namespace _08_Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Privates { get; }
    }
}
