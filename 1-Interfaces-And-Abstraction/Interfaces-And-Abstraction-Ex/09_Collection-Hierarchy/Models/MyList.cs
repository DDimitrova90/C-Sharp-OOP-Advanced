﻿namespace _09_Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class MyList : IMyList
    {
        public MyList()
        {
            this.Items = new List<string>();
        }

        private List<string> Items { get; }

        public int Used
        {
            get
            {
                return this.Items.Count;
            }
        }

        public int Add(string item)
        {
            this.Items.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string toBeRemoved = this.Items.First();
            this.Items.Remove(toBeRemoved);
            return toBeRemoved;
        }
    }
}
