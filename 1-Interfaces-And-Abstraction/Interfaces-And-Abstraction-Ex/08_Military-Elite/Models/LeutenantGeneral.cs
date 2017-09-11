namespace _08_Military_Elite.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IList<ISoldier> soldiers) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = soldiers;
        }

        public IList<ISoldier> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Privates:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");

            return sb.ToString().Trim();
        }
    }
}
