namespace _09_Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            this.Items = new List<string>();
        }

        private List<string> Items { get; }

        public int Add(string item)
        {
            this.Items.Add(item);
            return this.Items.Count - 1;
        }
    }
}
